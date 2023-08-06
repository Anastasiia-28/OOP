namespace OOP_HW2
{
    public abstract class MusicalInstrument
    {
        protected string name;
        protected string description;
        protected string historyOfCreation;
        public MusicalInstrument(string name, string description, string history)
        {
            this.name = name;
            this.description = description;
            historyOfCreation = history;
        }

        public abstract void Sound();
        public void Show()
        {
            Console.WriteLine(name);
        }
        public void Desc()
        {
            Console.WriteLine(description);
        }
        public void History()
        {
            Console.WriteLine(historyOfCreation);
        }
    }

    public class Violin : MusicalInstrument
    {
        public Violin(string name, string description, string history) : base(name, description, history) { }

        public override void Sound()
        {
            Console.WriteLine("Звук скрипки ^_^_^_^");
        }
    }
    public class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description, string history) : base(name, description, history) { }

        public override void Sound()
        {
            Console.WriteLine("Звук тромбона -_-_-_-");
        }
    }
    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description, string history) : base(name, description, history) { }

        public override void Sound()
        {
            Console.WriteLine("Звук укулеле *^_*^_*^_*^");
        }
    }
    public class Cello : MusicalInstrument
    {
        public Cello(string name, string description, string history) : base(name, description, history) { }

        public override void Sound()
        {
            Console.WriteLine("Звук віолончелі *-^*-^*-^");
        }
    }

    //public class MusicalInstrument
    //{
    //    protected string name;
    //    protected string description;
    //    protected string historyOfCreation;
    //    public MusicalInstrument(string name, string description, string history)
    //    {
    //        this.name = name;
    //        this.description = description;
    //        historyOfCreation = history;
    //    }

    //    public virtual void Sound()
    //    {
    //        Console.WriteLine("Sounding");
    //    }
    //    public virtual void Show()
    //    {
    //        Console.WriteLine(name);
    //    }
    //    public virtual void Desc()
    //    {
    //        Console.WriteLine(description);
    //    }
    //    public virtual void History()
    //    {
    //        Console.WriteLine(historyOfCreation);
    //    }
    //}

    //public class Violin : MusicalInstrument
    //{
    //    public Violin(string name, string description, string history) : base(name, description, history) { }

    //    public override void Sound()
    //    {
    //        Console.WriteLine("Sound of Violin");
    //    }
    //    public override void Show()
    //    {
    //        Console.WriteLine(name);
    //    }
    //    public override void Desc()
    //    {
    //        Console.WriteLine(description);
    //    }
    //    public override void History()
    //    {
    //        Console.WriteLine(historyOfCreation);
    //    }
    //}
    //public class Trombone : MusicalInstrument
    //{
    //    public Trombone(string name, string description, string history) : base(name, description, history) { }

    //    public override void Sound()
    //    {
    //        Console.WriteLine("Sound of Trombone");
    //    }
    //    public override void Show()
    //    {
    //        Console.WriteLine(name);
    //    }
    //    public override void Desc()
    //    {
    //        Console.WriteLine(description);
    //    }
    //    public override void History()
    //    {
    //        Console.WriteLine(historyOfCreation);
    //    }
    //}
    //public class Ukulele : MusicalInstrument
    //{
    //    public Ukulele(string name, string description, string history) : base(name, description, history) { }

    //    public override void Sound()
    //    {
    //        Console.WriteLine("Sound of Ukulele");
    //    }
    //    public override void Show()
    //    {
    //        Console.WriteLine(name);
    //    }
    //    public override void Desc()
    //    {
    //        Console.WriteLine(description);
    //    }
    //    public override void History()
    //    {
    //        Console.WriteLine(historyOfCreation);
    //    }
    //}
    //public class Cello : MusicalInstrument
    //{
    //    public Cello(string name, string description, string history) : base(name, description, history) { }

    //    public override void Sound()
    //    {
    //        Console.WriteLine("Sound of Cello");
    //    }
    //    public override void Show()
    //    {
    //        Console.WriteLine(name);
    //    }
    //    public override void Desc()
    //    {
    //        Console.WriteLine(description);
    //    }
    //    public override void History()
    //    {
    //        Console.WriteLine(historyOfCreation);
    //    }
    //}
}
