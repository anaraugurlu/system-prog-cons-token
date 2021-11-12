using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using system_prog_cons_token.Commands;

namespace system_prog_cons_token.ViewModels
{
    class MainViewModel:BaseViewModel
    {

        public RelayCommand StartButton { get; set; }
        public RelayCommand ProgressBar { get; set; }
        public RelayCommand CancelButton { get; set; }
        public RelayCommand FileButton { get; set; }
        public RelayCommand DecRadioButton { get; set; }
        public RelayCommand EncRadioButton { get; set; }
        public MainViewModel()
        {
            StartButton = new RelayCommand((sender) => { 
            
            });
            CancelButton = new RelayCommand((sender) => {

            });
            FileButton = new RelayCommand((sender) => {

            });
           
        }

    }
}
