using Anketa_2.Models;

#region Notes
/*
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>()
        {
            new Car("Audi", "R7", new DateTime(2019, 11, 11)),
            new Car("Tesla", "Model S", new DateTime(2019, 11, 11)),
            new Car("BMW", "X5", new DateTime(2019, 11, 11)),
            new Car("Hyundai", "Elantra", new DateTime(2019, 11, 11))
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var select in listBox1.SelectedItems)
                listBox2.Items.Add(select);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var car in cars)
                listBox1.Items.Add(car);
        }
    }
*/
#endregion

#region Task
/*
Add düyməsinə basılanda, insan haqqında olan məlumat ListBoxa
əlavə olunur.
Save basılarsa Listboxdakı elementlər json fayla yazır.
Load basılarsa Listboxa elementləri json fayldan yükləyir.
Change duymesine basilanda ListBoxdan secilen element textBoxlara verilir ve deyisiklik etmek mumkun hala gelir
*/
#endregion


namespace Anketa_2;

public partial class Form1 : Form
{
    Person person;
    List<Person> persons = new List<Person>();
    DataBase data;
    bool saveCheck = true;
    bool loadCheck = true;

    public Form1()
    {
        InitializeComponent();
        data = new DataBase();
        //new List<Person>();
    }

    void Form1_Load(object sender, EventArgs e) => listBox1.Items.Clear();

    void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            saveCheck = true;
            person = new Person(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, ushort.Parse(textBox5.Text));
            persons.Add(person);
            listBox1.Items.Add(person.Name);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    void btnSave_Click(object sender, EventArgs e)
    {
        if (saveCheck)
        {
            foreach (var person in persons)
                data.AddPerson(person);
        }
        else
            MessageBox.Show("All Changes Saves in Json", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        saveCheck = false;
    }

    void btnLoad_Click(object sender, EventArgs e)
    {
        if (loadCheck)
        {
            foreach (var person in data.Persons)
            {
                listBox1.Items.Add(person.Name);
                persons.Add(person);
            }
        }
        else
            MessageBox.Show("All Info Download in ListBox", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        loadCheck = false;
    }

    void btnChange_Click(object sender, EventArgs e)
    {
        textBox1.Clear();
        textBox2.Clear();
        textBox3.Clear();
        textBox4.Clear();
        textBox5.Clear();
        try
        {
            Person person1 = new Person();
            foreach (var person in persons)
            {
                if (person.Name == listBox1.SelectedItem)
                {
                    person1 = person;
                    break;
                }
            }
            if (person1.Name != null)
            {
                textBox1.Text = person1.Name;
                textBox2.Text = person1.Surname;
                textBox3.Text = person1.Email;
                textBox4.Text = person1.Phone;
                textBox5.Text = person1.BirthYear.ToString();
            }
            else
                MessageBox.Show("Select Item", "Error Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}