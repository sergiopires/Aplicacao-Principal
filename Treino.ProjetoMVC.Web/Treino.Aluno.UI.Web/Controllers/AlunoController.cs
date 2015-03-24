using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Treino.Aluno.DomainModel;
using Treino.Aluno.UI.Web.ViewModels;

using Treino.Aluno.Repository;
using PagedList;


namespace Treino.Aluno.UI.Web.Controllers
{
    public class AlunoController : Controller
    {
        AlunoREP repositorioAluno = new AlunoREP();
        SexoREP repositorioSexo = new SexoREP();
        CursoREP repositorioCurso = new CursoREP();


        #region Post

        public ActionResult Cadastrar()
        {
            var viewModel = new AlunoVM();


            viewModel.ListaCurso = new SelectList(repositorioCurso.ListaCurso(), "COD_CURSO", "NOME");

            viewModel.ListaSexo = new SelectList(repositorioSexo.ListaSexo(), "Cod_Sexo", "DESCRICAO");

            return View(viewModel);
        }


        public ActionResult Editar(int id)
        {
            var viewModel = new AlunoVM();


            viewModel.ListaCurso = new SelectList(repositorioCurso.ListaCurso(), "COD_CURSO", "NOME");

            viewModel.ListaSexo = new SelectList(repositorioSexo.ListaSexo(), "Cod_Sexo", "DESCRICAO");

            viewModel.Aluno = repositorioAluno.ListaAluno().Single(x => x.Cod_Aluno == id);

            return View(viewModel);

        }


        public ActionResult Remover(Int32 id)
        {
            repositorioAluno.Excluir(id);
            return RedirectToAction("Listar");
        }


        public ActionResult Listar(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NomeParam = String.IsNullOrEmpty(sortOrder) ? "NOME" : "";
            ViewBag.DataParam = sortOrder == "Datetime" ? "DataNascimento" : "Datetime";

            var viewModel = new AlunoVM();

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            viewModel.Alunos = repositorioAluno.ListaAluno();


            if (!String.IsNullOrEmpty(searchString))
            {
                viewModel.Alunos =
                    repositorioAluno.ListaAluno().Where(x => x.Nome.ToUpper().Contains(searchString.ToUpper())
                    || x.Email.ToUpper().Contains(searchString));
            }



            switch (sortOrder)
            {
                case "NOME":
                    viewModel.Alunos = viewModel.Alunos.OrderBy(x => x.Nome);
                    break;

                case "Datetime":
                    viewModel.Alunos = viewModel.Alunos.OrderBy(x => x.DataNascimento);
                    break;

                case "DataNascimento":
                    viewModel.Alunos = viewModel.Alunos.OrderByDescending(x => x.DataNascimento);
                    break;

                default:
                    viewModel.Alunos = viewModel.Alunos.OrderByDescending(x => x.Nome);

                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            
            return View(viewModel.Alunos.ToPagedList(pageNumber,pageSize));
        }

        #endregion



        [HttpPost]
        public ActionResult Cadastrar(AlunoVM alu)
        {
            repositorioAluno.Inserir(alu.Aluno);


            return RedirectToAction("Listar");
        }


        [HttpPost]
        public ActionResult Editar(AlunoVM vm, int id)
        {

            vm.Aluno.Cod_Aluno = id;
            vm.Aluno.Cod_Curso = vm.Aluno.Cod_Curso;
            vm.Aluno.Cod_Sexo = vm.Aluno.Cod_Sexo;


            repositorioAluno.Atualizar(vm.Aluno);

            return RedirectToAction("Listar");
        }


        public ActionResult Endereco(int id)
        {

            var viewModel = new AlunoVM();


            viewModel.ListaCurso = new SelectList(repositorioCurso.ListaCurso(), "COD_CURSO", "NOME");

            viewModel.ListaSexo = new SelectList(repositorioSexo.ListaSexo(), "Cod_Sexo", "DESCRICAO");

            viewModel.Aluno = repositorioAluno.ListaAluno().Single(x => x.Cod_Aluno == id);

            return View(viewModel);
        }



        [HttpPost]
        public ActionResult Endereco(AlunoVM vm, int id)
        {

            vm.Aluno.Cod_Aluno = id;
            vm.Aluno.Cod_Curso = vm.Aluno.Cod_Curso;
            vm.Aluno.Cod_Sexo = vm.Aluno.Cod_Sexo;


            repositorioAluno.AtualizarEndereco(vm.Aluno);

            return RedirectToAction("Listar");
        }

    }
}