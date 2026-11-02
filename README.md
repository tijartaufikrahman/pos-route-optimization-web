<p align="center">
  <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original.svg" alt="ASP.NET Core MVC" width="70" height="70" />
</p>

<h1 align="center">Sistem Optimasi Rute - Web Management Portal</h1>

<p align="center">
  <b>Modern ASP.NET Core 8 MVC web dashboard for Branch Managers to manage shipments, configure courier assignments, trigger ACO route optimization, and monitor delivery operations.</b>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet&logoColor=white" alt=".NET 8" />
  <img src="https://img.shields.io/badge/ASP.NET_Core-MVC-512BD4?style=flat&logo=dotnet&logoColor=white" alt="ASP.NET Core MVC" />
  <img src="https://img.shields.io/badge/Bootstrap-5.3-7952B3?style=flat&logo=bootstrap&logoColor=white" alt="Bootstrap 5" />
  <img src="https://img.shields.io/badge/jQuery-3.7-0769AD?style=flat&logo=jquery&logoColor=white" alt="jQuery" />
  <img src="https://img.shields.io/badge/DataTables-2.3-336699?style=flat" alt="DataTables" />
  <img src="https://img.shields.io/badge/Leaflet-Maps-199900?style=flat&logo=leaflet&logoColor=white" alt="Leaflet" />
</p>

---

## 📌 Overview

**Sistem Optimasi Rute Web Management Portal** is a web-based operational system tailored for **PT Pos Indonesia (KCP 44188 Malangbong)**. It serves as the primary dispatcher interface for **Branch Managers** and operations supervisors to organize daily shipment logistics, generate optimized delivery routes using Ant Colony Optimization (ACO), and monitor real-time delivery status updates.

The application communicates seamlessly with the **Sistem Optimasi Web API** via REST endpoints.

---

## 🚀 Key Features

- **Executive Operations Dashboard:**
  - Real-time key metrics: Total Shipments, Assigned Deliveries, Delivered Items, Pending Tasks.
  - Interactive calendar date-picker with synchronized Indonesian date formatting.
  - Quick-view operational status tables with courier progress indicators.
- **Shipment Administration (`Data Kiriman`):**
  - High-performance tabular display powered by DataTables with sorting, multi-column search, and pagination.
  - Bulk shipment import directly from Excel files (`.xlsx`) with instant field validation.
  - Detailed shipment tracking, geographic coordinates viewer, and status lifecycle inspection.
- **ACO Route Planning & Assignment (`Penugasan Pengantaran`):**
  - Interactive multi-stop routing engine using **Ant Colony Optimization (ACO)**.
  - Visual route preview on interactive maps (Leaflet / Mapbox / OpenStreetMap).
  - Dynamic drag-and-drop or automated sequencing for waypoint deliveries.
- **Delivery Verification & POD Viewer:**
  - Inspection of Proof of Delivery (POD) submissions, including captured recipient signatures, photos, and GPS timestamps.
- **Master Data & Settings:**
  - Branch office coordinate settings (`Kantor Pos KCP Malangbong`).
  - Courier accounts and role-based access control.

---

## 🛠️ Technology Stack

| Component | Technologies |
|---|---|
| **Backend & Engine** | ASP.NET Core 8.0 MVC (Model-View-Controller) |
| **Language** | C# 12 / Razor View Engine |
| **CSS Framework** | Bootstrap 5.3 + Custom POS Indonesia Enterprise Theme |
| **Client Scripting** | JavaScript (ES6+), jQuery 3.7.1 |
| **Data Tables** | DataTables.net 2.3.5 with Bootstrap 5 integration |
| **Maps & Routing** | Leaflet / OpenStreetMap / Polyline decoders |
| **Spreadsheet Helper** | SheetJS (XLSX.js) |

---

## 📂 Project Architecture

```plaintext
V2/SistemOptimasi/SistemOptimasi/
├── Controllers/              # MVC Action Controllers (Home, Kiriman, Penugasan, Auth, etc.)
├── Models/                   # ViewModels & Client-side data models
├── Views/
│   ├── Home/                 # Operational Dashboard (Index.cshtml) & Settings
│   ├── Kiriman/              # Shipment management & Detail views
│   ├── Penugasan/            # ACO Route Optimization & Assignment views
│   ├── Auth/                 # Login ("Silahkan Masuk"), Forgot Password, OTP Verification
│   └── Shared/               # _Layout.cshtml, navigation sidebar, & partials
├── wwwroot/                  # Static assets
│   ├── custom/               # Pos Indonesia logos, icons, and AdminLTE theme assets
│   ├── css/                  # auth.css, custom responsive style sheets
│   └── js/                   # Dashboard analytics and UI helper scripts
├── Properties/
│   └── launchSettings.json   # Kestrel local network profiles (Default: Port 20001)
├── appsettings.json          # Web API BaseUrl configuration
└── Program.cs                # Middleware pipeline, static files, routing setup
```

---

## ⚙️ Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Running instance of **[Sistem Optimasi Web API](https://github.com/tijartaufikrahman/pos-route-optimization-api)** (Default: `http://localhost:21001`)

### Installation & Configuration

1. **Clone the repository:**
   ```bash
   git clone https://github.com/tijartaufikrahman/pos-route-optimization-web.git
   cd pos-route-optimization-web
   ```

2. **Configure API Base URL:**
   Open `appsettings.json` and ensure the `ApiSettings:BaseUrl` points to your running backend API:
   ```json
   {
     "ApiSettings": {
       "BaseUrl": "http://localhost:21001"
     }
   }
   ```

3. **Restore & Build:**
   ```bash
   dotnet restore
   dotnet build
   ```

4. **Run the Application:**
   ```bash
   dotnet run --launch-profile "http"
   ```

5. **Open in Browser:**
   Visit [http://localhost:20001/](http://localhost:20001/) to access the portal.

---

## 🔑 Authentication

Access to the portal requires a valid **Branch Manager** account:
- **Username:** `branch_manager`
- **Password:** `password`
- **Login URL:** [http://localhost:20001/Auth/Login](http://localhost:20001/Auth/Login)

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).
