﻿using System.Collections.Generic;
using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class RoomRepository : Repository<Room> {
        public RoomRepository(AccommodationManagerAppContext context) : base(context) {}

        public Room GetByIdWithBuilding(int id) {
            return Context.Set<Room>().Include("Building").FirstOrDefault(r => r.Id == id);
        }

        public List<Room> GetAllWithBuilding() {
            return Context.Set<Room>().Include("Building").ToList();
        }
        
        public List<Room> GetAllByBuildingId(int buildingId) {
            return Context.Set<Room>().Where(r => r.BuildingId == buildingId).ToList();
        }

        public List<Room> GetAllWithBuildingAndContract() {
            return Context.Set<Room>().Include("Building").Include("Contract").ToList();
        }

        public Room GetByRoomNumber(string roomNumber) {
            return Context.Set<Room>().FirstOrDefault(r => r.RoomNumber == roomNumber);
        }

        public Room GetByIdWithContract(int id) {
            return Context.Set<Room>().Include("Contract").FirstOrDefault(r => r.Id == id);
        }
    }
}