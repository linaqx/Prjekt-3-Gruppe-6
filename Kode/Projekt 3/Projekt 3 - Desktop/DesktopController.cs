using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3___Desktop
{
    class DesktopController
    {

    }

    public list<Entertainment> ReturnAllEntertainments()
    {
        //kald WCF solution.Projekt 3 - WCF. EntertainmentController.FindAllEntertainments();
        DesktopService.ReturnAllEntertainments();
        return null;
    }

    public list<Entertainment> ReturnEntertainmentBySearch()
    {
        return null;
    }
}
