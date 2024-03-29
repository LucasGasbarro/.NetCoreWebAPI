﻿using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Model;
using System.Collections.Generic;

namespace SmartSchool.API.Data
{
    public class SmartContext : DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> options): base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoID, AD.DisciplinaID });

            builder.Entity<Professor>()
                .HasData(new List<Professor>(){
                    new Professor(1, "Lauro"),
                    new Professor(2, "Roberto"),
                    new Professor(3, "Ronaldo"),
                    new Professor(4, "Rodrigo"),
                    new Professor(5, "Alexandre"),
                });

            builder.Entity<Disciplina>()
                .HasData(new List<Disciplina>{
                    new Disciplina(1, "Matemática", 1),
                    new Disciplina(2, "Física", 2),
                    new Disciplina(3, "Português", 3),
                    new Disciplina(4, "Inglês", 4),
                    new Disciplina(5, "Programação", 5)
                });

            builder.Entity<Aluno>()
                .HasData(new List<Aluno>(){
                    new Aluno(1, "Marta", "Kent", "33225555"),
                    new Aluno(2, "Paula", "Isabela", "3354288"),
                    new Aluno(3, "Laura", "Antonia", "55668899"),
                    new Aluno(4, "Luiza", "Maria", "6565659"),
                    new Aluno(5, "Lucas", "Machado", "565685415"),
                    new Aluno(6, "Pedro", "Alvares", "456454545"),
                    new Aluno(7, "Paulo", "José", "9874512")
                });

            builder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina() {AlunoID = 1, DisciplinaID = 2 },
                    new AlunoDisciplina() {AlunoID = 1, DisciplinaID = 4 },
                    new AlunoDisciplina() {AlunoID = 1, DisciplinaID = 5 },
                    new AlunoDisciplina() {AlunoID = 2, DisciplinaID = 1 },
                    new AlunoDisciplina() {AlunoID = 2, DisciplinaID = 2 },
                    new AlunoDisciplina() {AlunoID = 2, DisciplinaID = 5 },
                    new AlunoDisciplina() {AlunoID = 3, DisciplinaID = 1 },
                    new AlunoDisciplina() {AlunoID = 3, DisciplinaID = 2 },
                    new AlunoDisciplina() {AlunoID = 3, DisciplinaID = 3 },
                    new AlunoDisciplina() {AlunoID = 4, DisciplinaID = 1 },
                    new AlunoDisciplina() {AlunoID = 4, DisciplinaID = 4 },
                    new AlunoDisciplina() {AlunoID = 4, DisciplinaID = 5 },
                    new AlunoDisciplina() {AlunoID = 5, DisciplinaID = 4 },
                    new AlunoDisciplina() {AlunoID = 5, DisciplinaID = 5 },
                    new AlunoDisciplina() {AlunoID = 6, DisciplinaID = 1 },
                    new AlunoDisciplina() {AlunoID = 6, DisciplinaID = 2 },
                    new AlunoDisciplina() {AlunoID = 6, DisciplinaID = 3 },
                    new AlunoDisciplina() {AlunoID = 6, DisciplinaID = 4 },
                    new AlunoDisciplina() {AlunoID = 7, DisciplinaID = 1 },
                    new AlunoDisciplina() {AlunoID = 7, DisciplinaID = 2 },
                    new AlunoDisciplina() {AlunoID = 7, DisciplinaID = 3 },
                    new AlunoDisciplina() {AlunoID = 7, DisciplinaID = 4 },
                    new AlunoDisciplina() {AlunoID = 7, DisciplinaID = 5 }
                });
        }

    }
}
