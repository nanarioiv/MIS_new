﻿using System;
using System.Windows.Forms;
using MIS.Data;
using MIS.Forms.AddEditForms;


namespace MIS.Forms.MainForms
{
    public partial class RequestWorksForm : Form
    {
        private readonly Repository _repository = Repository.RepositoryInstance;

        private readonly Request _request;
        public RequestWorksForm(Request request)
        {
            _request = request;
            InitializeComponent();
            UpdateDatagrid();
        }

        /// <summary>
        ///     Метод обновления данных таблицы
        /// </summary>
        private void UpdateDatagrid()
        {
            try
            {
                requestWorkBindingSource.DataSource = null;
                requestWorkBindingSource.DataSource = _repository.GetEntityes<RequestWork>(rw=>rw.Request_ID==_request.Request_ID);
                dataGridView.ClearSelection();
            }
            catch (Exception e)
            {
                ExceptionHandler.HandleException(e);
            }
        }

        /// <summary>
        /// Обработчик события нажатия ячеек с икноками редактирования и удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
                return;
            // если нажали на ячейку с иконкой редактирования
            if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as RequestWork;
                // открываем форму в режиме редактирования (перегруженные конструктор)
                new AddEditRequestWorkForm(item).ShowDialog();
                UpdateDatagrid();
            }
            // если нажали на ячейку с иконкой удаления
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                var item = dataGridView.SelectedRows[0].DataBoundItem as RequestWork;
                var result = MessageBox.Show($"Удалить должность с ID = {item.RequestWork_ID}? ", "",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;

                try
                {
                    // удаляем 
                    _repository.Delete(item);
                    // обновляем таблицу с данными
                    UpdateDatagrid();
                }
                catch (Exception exception)
                {
                    ExceptionHandler.HandleException(exception);
                }
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки Добавить
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // открываем форму в режиме добавления (пустой конструктор
            var result = new AddEditRequestWorkForm(_request).ShowDialog();
            if (result == DialogResult.OK)
            {
                //если были добавлены данные обновляем таблицу
                UpdateDatagrid();
            }
        }

        private void SpareParametersForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}