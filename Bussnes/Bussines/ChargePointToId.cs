using DataAccess.Entity;
using Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnes.Bussines
{
    public class ChargePointToId
    {
        public ChargePointToId()
        {

        }
        ChargePointRequest _chargePointRequest;
        ChargePoint chargePoint;
        UnitOfWork unitOfWork;
        public ChargePointToId(ChargePointRequest changePointRequest)
        {
            _chargePointRequest = changePointRequest;
            unitOfWork = new UnitOfWork();
        }
        public ChargePoint GetChargerPoint()
        {
            var result = unitOfWork.GetRepository<ChargePoint>().Get(x => x.LocationId == _chargePointRequest.LocationId);
            return result.Data;
        }
        public ChargePoint GetChargerPointUpdate()
        {
            chargePoint = new ChargePoint();
            foreach (var item in _chargePointRequest.chargePoints)
            {
                chargePoint.ChangePointId = item.ChangePointId;
                chargePoint.Status= item.Status;
                chargePoint.FloorLevel = item.FloorLevel;
                chargePoint.LastUpdate = item.LastUpdate;
               
            }
            var result = unitOfWork.GetRepository<ChargePoint>().Update(chargePoint);
            return result.Data;
        }

    }
}
