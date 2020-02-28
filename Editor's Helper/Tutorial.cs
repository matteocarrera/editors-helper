using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Editor_Helper
{
    public partial class Tutorial : Form
    {
        private List<TutorialItem> _tutorialItems = new List<TutorialItem>();
        private int counter = 0;

        public Tutorial()
        {
            InitializeComponent();

            InitializeTutorialList();

            SetTutorialItem();
            CheckBackButton();
            CheckForwardButton();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            counter++;
            CheckForwardButton();
            CheckBackButton();
            SetTutorialItem();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            counter--;
            CheckForwardButton();
            CheckBackButton();
            SetTutorialItem();
        }

        private void SetTutorialItem()
        {
            if (counter == _tutorialItems.Count) Close();
            else
            {
                TutorialTextLabel.Text = _tutorialItems[counter].Text;
                TutorialTextLabel.Location = new Point(12, 285 + 84 / 2 - TutorialTextLabel.Height / 2);
                TutorialPicturesBox.Image = _tutorialItems[counter].Image;
            }
        }

        private void CheckBackButton()
        {
            if (counter == 0) BackButton.Enabled = false;
            else BackButton.Enabled = true;
        }

        private void CheckForwardButton()
        {
            if (counter == _tutorialItems.Count - 1) ForwardButton.Text = "Завершить обучение";
            else ForwardButton.Text = "Далее";
        }

        private void InitializeTutorialList()
        {
            _tutorialItems.Add(new TutorialItem("Добро пожаловать в программу \"Burone Editor's Helper\" !", Properties.Resources._1));
            _tutorialItems.Add(new TutorialItem("Чтобы начать работу, нажмите на кнопку \"Выбрать файл\" и выберите нужный из списка доступных. \nВнимание! Файл, в котором вы будете работать, должен быть обязательно открыт!", Properties.Resources._2));
            _tutorialItems.Add(new TutorialItem("Вы также можете поставить лимит времени для работы, либо можете пропустить этот шаг.", Properties.Resources._3));
            _tutorialItems.Add(new TutorialItem("Нажмите на кнопку \"Старт\", программа свернётся автоматически, включится счетчик времени и нажатых символов.", Properties.Resources._4));
            _tutorialItems.Add(new TutorialItem("В любой момент Вы можете нажать на кнопку \"Пауза\", при этом Вы сможете вернуться к работе позже.", Properties.Resources._5));
            _tutorialItems.Add(new TutorialItem("По завершению работы нажмите на кнопку \"Остановить\", после этого Вам откроется возможность создать отчет о проделанной работе.", Properties.Resources._6));
            _tutorialItems.Add(new TutorialItem("Нажмите на кнопку \"Создать отчет\", выберите место, куда хотите сохранить Ваш отчет. После сохранения отчет откроется автоматически.", Properties.Resources._7));
            _tutorialItems.Add(new TutorialItem("Готово! Вы выполнили свою работу! Теперь можете отправлять готовый документ и отчет на проверку!\nУдачи в работе!", Properties.Resources._8));
        }
    }
}
