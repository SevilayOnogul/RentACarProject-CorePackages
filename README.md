# 🧩 Rent A Car Core Packages

Bu repo, **Rent A Car Project** uygulamasının backend tarafında kullanılan **ortak paketleri ve modülleri** içerir.  
Proje, modüler bir yapı ile geliştirilmiş olup, **Core Packages** sayesinde ana projede tekrar eden kodlar ve bağımlılıklar tek bir yerde yönetilmektedir.

---

## 🛠️ Kullanılan Teknolojiler ve Kütüphaneler
- **.NET 8 / C#**
- **FluentValidation**
- **MediatR (CQRS)**
- **Microsoft.Extensions.Configuration**
- **Entity Framework Core**
- **System.Linq.Dynamic.Core**
- **Serilog** (Dosya ve SQL Logging)
- **Microsoft.IdentityModel.Tokens / JWT**
- **Otp.NET**

---

## 📂 Paketler
- **Core.CrossCuttingConcerns**: Ortak iş kuralları ve yardımcı sınıflar  
- **Core.Persistence**: Veritabanı ve repository işlemleri  
- **Core.Security**: JWT ve güvenlik katmanları  
- **Core.Application**: Ortak uygulama servisleri  

---

## 🔗 Ana Projeye Yönlendirme
Bu paketler **Rent A Car Project** ana projesinde kullanılır.  
Ana projeyi incelemek veya çalıştırmak için [Rent A Car Project](https://github.com/SevilayOnogul/RentACarProject) reposuna göz atabilirsiniz.

---

## ⚡ Kurulum
1. Reponuzu klonlayın:  
```bash
git clone https://github.com/SevilayOnogul/RentACarProject-CorePackages.git
```
2.Visual Studio’da çözümü açın.

3.Tüm projeleri build edin.

4.Daha sonra ana projeyi çalıştırabilirsiniz: [Rent A Car Project](https://github.com/SevilayOnogul/RentACarProject)


