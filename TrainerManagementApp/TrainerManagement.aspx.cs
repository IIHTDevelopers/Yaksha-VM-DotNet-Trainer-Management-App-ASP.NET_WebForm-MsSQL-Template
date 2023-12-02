using TrainerManagementApp.DAL;
using TrainerManagementApp.Model;
using System;
using System.Web.UI;

namespace TrainerManagementApp
{
    public partial class TrainerManagement : Page
    {
        private readonly datalayer _dataLayer;
        private readonly TrainerManagementApp.DAL.Interfaces.ITrainerService _trainerService;

        public TrainerManagement()
        {
            _dataLayer = new datalayer();
            _trainerService = new DAL.Services.TrainerService(new DAL.Services.TrainerRepository(new TrainerManagementApp.DAL.TrainerDbContext()));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            //write your code here
            throw new NotImplementedException();
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write your code here
            throw new NotImplementedException();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //write your code here
            throw new NotImplementedException();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //write your code here
            throw new NotImplementedException();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
