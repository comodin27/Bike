﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Interfaces;
using BAL.Models;

namespace BAL.Repositories
{
    public class RepositoryRents : IRepositoryRents
    {
        public int AddRent(ModelRents model)
        {
            try
            {
                using (var db = new DAL.BikeEntities())
                {
                    db.Rents.Add(MapToDB(model));
                    db.SaveChanges();
                    return MapToApp(db.Set<DAL.Rents>().OrderByDescending(t => t.id).FirstOrDefault()).id;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public void DeleteRent(int id)
        {
            try
            {
                using (var db = new DAL.BikeEntities())
                {
                    var aDelet = db.Rents.Find(id);
                    db.Rents.Remove(aDelet);
                    db.SaveChanges();
                }
            }
            catch ( Exception ex)
            {

            }

        }
       
        public List<ModelDetailRents> SelectAll()
        {
            try
            {
                using (var db = new DAL.BikeEntities())
                {
                    var result = from d in db.Rents
                                 join c in db.Clients
                                 on d.clients_id equals c.id
                                 join p in db.TypePromotions
                                 on d.typepromotions_id equals p.id
                                 into cJoin
                                 from cj in cJoin.DefaultIfEmpty()
                                 select new ModelDetailRents
                                 {
                                     id = d.id,
                                     price = d.price,
                                     typepromotions_id = d.typepromotions_id,
                                     clients_id = d.clients_id,
                                     date = d.date,
                                     quantity = d.quantity,
                                     client = c.name,
                                     promotion = cj.name

                                 };

                    //return db.Rents.Select(MapToApp).ToList();
                    return result.ToList(); ;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public ModelRents SelectRentById(int id)
        {
            try
            {
                using (var db = new DAL.BikeEntities())
                {
                    return MapToApp(db.Rents.Find(id));
                }
            }
            catch ( Exception ex)
            {
                return null;
            }
        }


        private DAL.Rents MapToDB(ModelRents model)
        {
            try
            {
                return new DAL.Rents()
                {
                    id = model.id,
                    price = model.price,
                    typepromotions_id = model.typepromotions_id,
                    clients_id = model.clients_id,
                    date = model.date,
                    quantity = model.quantity
                };
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        private ModelRents MapToApp(DAL.Rents modeldb)
        {
            try
            {
                return new ModelRents()
                {
                    id = modeldb.id,
                    price = modeldb.price,
                    typepromotions_id = modeldb.typepromotions_id,
                    clients_id = modeldb.clients_id,
                    date = modeldb.date,
                    quantity = modeldb.quantity
                };
            }
            catch ( Exception ex)
            {
                return null;
            }

        }
    }
}
