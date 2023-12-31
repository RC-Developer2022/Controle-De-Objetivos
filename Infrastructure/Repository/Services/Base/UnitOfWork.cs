﻿using Infrastructure.Repository.Interfaces.Base;

namespace Infrastructure.Repository.Services.Base;

public sealed class UnitOfWork : IUnitOfWork
{
    private readonly DapperContext _session;

    public UnitOfWork(DapperContext session)
    {
        _session = session;
    }

    public void BeginTransaction()
    {
        _session.Transaction = _session.Connection.BeginTransaction();
    }

    public void Commit()
    {
        _session.Transaction.Commit();
        Dispose();
    }

    public void Rollback()
    {
        _session.Transaction.Rollback();
        Dispose();
    }

    public void Dispose() => _session.Transaction?.Dispose();
}
