﻿using System;
using System.Threading.Tasks;
using BulkBuilder.Application.WorkoutBuilder.Exercises.Data;
using BulkBuilder.Application.WorkoutBuilder.Workouts.Data;

namespace BulkBuilder.Application.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        IExerciseRepository Exercise { get; }
        IWorkoutRepository Workout { get; }
        IWorkoutExerciseRepository WorkoutExercise { get; }
        Task CommitAsync();
    }
}
