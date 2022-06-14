
using MedKart.DataAccess;
using MedKart.DataAccess.Repository.IRepository;
using MedKart.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedKartWeb.Controllers;
[Area("Admin")]
public class MedicineTypeController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    public MedicineTypeController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        IEnumerable<MedicineType> objMedicineTypeList = _unitOfWork.MedicineType.GetAll();
        return View(objMedicineTypeList);
    }

    //GET
    public IActionResult Create()
    {

        return View();
    }


    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(MedicineType obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.MedicineType.Add(obj);
            _unitOfWork.Save();
            TempData["success"] = "Medicine Type created successfully";
            return RedirectToAction("Index");

        }
        return View(obj);
    }

    //GET
    public IActionResult Edit(int? id)
    {
        if(id==null || id==0)
        {
            return NotFound();
        }
        var MedicineTypeFromDb = _unitOfWork.MedicineType.GetFirstOrDefault(u => u.Id == id); 
        if(MedicineTypeFromDb == null)
        {
            return NotFound();
        }
        return View(MedicineTypeFromDb);
    }


    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(MedicineType obj)
    {
        if (ModelState.IsValid)
        {
            _unitOfWork.MedicineType.Update(obj);
            _unitOfWork.Save();
            TempData["success"] = "Medicine Type updated successfully";
            return RedirectToAction("Index");

        }
        return View(obj);
    }

    //GET
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        var MedicineTypeFromDb = _unitOfWork.MedicineType.GetFirstOrDefault(u => u.Id == id);
        if (MedicineTypeFromDb == null)
        {
            return NotFound();
        }
        return View(MedicineTypeFromDb);
    }


    //POST
    [HttpPost,ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePOST(int? id)
    {
        var obj= _unitOfWork.MedicineType.GetFirstOrDefault(u => u.Id == id);
        if (obj==null)
        {
            return NotFound();
        }

        _unitOfWork.MedicineType.Remove(obj);
        _unitOfWork.Save();
        TempData["success"] = "Medicine Type deleted successfully";
        return RedirectToAction("Index");
    }

}
