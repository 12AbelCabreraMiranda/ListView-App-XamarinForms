using MyListView.Models;
using MyListView.MyDataSourse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyListView.ViewModels
{
    class HumanViewModels
    {
        private ObservableCollection<Human> humans;
        public ObservableCollection<Human> Humans
        {
            get { return humans; }
            set
            {
                humans = value;
            }
        }

        public HumanViewModels()
        {

            Humans = new ObservableCollection<Human>();

            MyData1 _context = new MyData1();

            foreach (var human in _context.Humans)
            {
                Humans.Add(human);
            }
        }
    }
}
