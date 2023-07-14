using System;
using System.Linq;


namespace form_app
{
    internal class WorkerPresenter
    {
        private readonly WorkerView _view;
        private readonly WorkerModel _model;

        public WorkerPresenter(WorkerView view, WorkerModel model)
        {
            _view = view;
            _model = model;
            _view.AddWorker += OnAddWorker;
            _view.PreviewWorker += OnPreviewWorker;
            _view.DeleteWorker += OnDeleteWorker;
            _view.EditWorker += OnEditWorker;
            _view.Import += OnImport;
            _view.Export += OnExport;
        }

        public WorkerView GetView() => _view;

        //metody on...
        private void OnAddWorker(object sender, EventArgs e)
        {
            var worker = _view.GetWorker();
            var validation = _model.WorkerValidation(worker);
            if (!validation)
            {
                _view.IsError();
                return;
            }
            _model.AddWorker(worker);

            _view.ShowWorkersList(_model.GetWorkers());
        }

        private void OnPreviewWorker(object sender, int id)
        {
            var worker = _model.GetWorkers().FirstOrDefault(w => w.Id == id);
            if (worker == null) return;
            _view.UseSelectedWorker(worker);
        }

        private void OnDeleteWorker(object sender, int id)
        {
            var worker = _model.GetWorkers().FirstOrDefault(w => w.Id == id);
            if (worker == null) return;
            _model.DeleteWorker(worker);
            _view.ShowWorkersList(_model.GetWorkers());
        }

        private void OnEditWorker(object sender, int id)
        {
            var newWorker = _view.GetWorker();
            var validation = _model.WorkerValidation(newWorker);
            if (!validation)
            {
                _view.IsError();
                return;
            }
            _model.EditWorker(id, newWorker);
            _view.ShowWorkersList(_model.GetWorkers());
        }

        private void OnImport(object sender, string path)
        {
            _model.Import(path);
            _view.ShowWorkersList(_model.GetWorkers());
        }

        private void OnExport(object sender, string path)
        {
            if(_model.GetWorkers().Count() != 0)
            {
                _model.Export(path);
                _view.PromptCorrect();
            }
            else
            {
                _view.IsError();
            }
           
        }


    }
}
