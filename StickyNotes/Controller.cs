using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyNotes
{
    public class Controller
    {
        // INSTANTIATE a new 'StickyNotes' by passing list as reference
        public Controller()
        {

            IServiceLocator factoryLocator = new FactoryLocator();

            // DECLARE a new dictionary to store sticky note instances
            IDictionary<int, Form> noteForms = new Dictionary<int, Form>();

            // INSTANTIATE a new NoteData component
            //INoteData noteData = (factoryLocator.Get<INoteData>() as IFactory<INoteData>).Create<NoteData>();
            INoteData noteData = new NoteData();

            IFactory<Form> formFactory = factoryLocator.Get<Form>() as IFactory<Form>;

            // RUN the initial application by passing the newly created dictionary and NoteData
            Application.Run(new StickyNotes(formFactory, noteForms, noteData));
        }
    }
}
