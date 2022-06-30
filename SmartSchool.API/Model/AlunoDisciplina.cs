namespace SmartSchool.API.Model
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }

        public AlunoDisciplina(int alunoID, int disciplinaID)
        {
            AlunoID = alunoID;
            DisciplinaID = disciplinaID;
        }

        public int AlunoID { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaID { get; set; }
        public Disciplina Disciplina { get; set; }

    }
}
