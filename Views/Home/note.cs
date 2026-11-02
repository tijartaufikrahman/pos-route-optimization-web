//@{
//    ViewData["Title"] = "Beranda";
//}

//< style >
//    .welcome - section {
//background: linear - gradient(135deg, #003366 0%, #1A5276 50%, #2C6E9C 100%);
//        border - radius: 16px;
//padding: 32px 36px;
//position: relative;
//overflow: hidden;
//}
//    .welcome - section::after {
//content: '';
//position: absolute;
//top: -60 %;
//right: -5 %;
//width: 350px;
//height: 350px;
//background: radial - gradient(circle, rgba(255, 255, 255, 0.05) 0 %, transparent 70 %);
//    border - radius: 50 %;
//}
//    .welcome - content {
//position: relative;
//    z - index: 2;
//}
//    .welcome - title {
//    font - size: 1.4rem;
//    font - weight: 700;
//color: #fff;
//        line - height: 1.3;
//}
//    .welcome - sub {
//    font - size: 0.85rem;
//color: rgba(255, 255, 255, 0.75);
//    line - height: 1.6;
//}
//    .welcome - badge {
//display: inline - flex;
//    align - items: center;
//gap: 6px;
//background: rgba(255, 255, 255, 0.12);
//border: 1px solid rgba(255, 255, 255, 0.15);
//padding: 5px 12px;
//    border - radius: 20px;
//color: rgba(255, 255, 255, 0.85);
//    font - size: 0.75rem;
//}
//    .welcome - img {
//width: 200px;
//height: auto;
//filter: drop - shadow(0 4px 20px rgba(0, 0, 0, 0.15));
//}

//    .stat - box {
//background: #fff;
//        border - radius: 14px;
//border: 1px solid #E2E8F0;
//        padding: 20px 24px;
//transition: all 0.25s ease;
//}
//    .stat - box:hover {
//        transform: translateY(-3px);
//box - shadow: 0 8px 25px rgba(0,51,102,0.08);
//border - color: #CBD5E1;
//    }
//    .stat - icon {
//width: 46px;
//height: 46px;
//    border - radius: 12px;
//display: flex;
//    align - items: center;
//    justify - content: center;
//    font - size: 1.2rem;
//    flex - shrink: 0;
//}
//    .stat - icon.s - blue {
//background: #DBEAFE; color: #003366; }
//    .stat - icon.s - orange {
//    background: #FEE2D6; color: #EA580C; }
//    .stat - icon.s - green {
//        background: #D1FAE5; color: #059669; }
//    .stat - icon.s - purple {
//            background: #EDE9FE; color: #7C3AED; }
//    .stat - num {
//                    font - size: 1.4rem;
//                    font - weight: 700;
//                color: #1E293B;
//        line - height: 1.2;
//                }
//    .stat - label {
//                    font - size: 0.78rem;
//                color: #64748B;
//        font - weight: 500;
//                }

//    .section - label {
//                    font - size: 1rem;
//                    font - weight: 700;
//                color: #1E293B;
//    }
//    .section - sub {
//                    font - size: 0.8rem;
//                color: #64748B;
//    }

//    .menu - box {
//                background: #fff;
//        border - radius: 14px;
//                border: 1px solid #E2E8F0;
//        padding: 22px;
//                    text - decoration: none;
//                display: block;
//                transition: all 0.25s ease;
//                }
//    .menu - box:hover {
//                    border - color: #003366;
//        transform: translateY(-4px);
//                    box - shadow: 0 12px 30px rgba(0,51,102,0.1);
//                }
//    .menu - box.box - icon {
//                width: 50px;
//                height: 50px;
//                    border - radius: 12px;
//                display: flex;
//                    align - items: center;
//                    justify - content: center;
//                    font - size: 1.3rem;
//                    margin - bottom: 14px;
//                }
//    .menu - box.box - icon.b - blue {
//                background: #DBEAFE; color: #003366; }
//    .menu - box.box - icon.b - orange {
//                    background: #FEE2D6; color: #EA580C; }
//    .menu - box.box - icon.b - green {
//                        background: #D1FAE5; color: #059669; }
//    .menu - box.box - icon.b - purple {
//                            background: #EDE9FE; color: #7C3AED; }
//    .menu - box.box - title {
//                                    font - weight: 600;
//                                    font - size: 0.95rem;
//                                color: #1E293B;
//        margin - bottom: 4px;
//                                }
//    .menu - box.box - desc {
//                                    font - size: 0.8rem;
//                                color: #64748B;
//        line - height: 1.5;
//                                }

//    .info - card {
//                                background: #fff;
//        border - radius: 14px;
//                                border: 1px solid #E2E8F0;
//    }
//    .info - card.c - header {
//                                padding: 16px 22px;
//                                    border - bottom: 1px solid #E2E8F0;
//        font - weight: 600;
//                                    font - size: 0.9rem;
//                                color: #1E293B;
//        display: flex;
//                                    align - items: center;
//                                gap: 10px;
//                                }
//    .info - card.c - body {
//                                padding: 16px 22px;
//                                }
//    .info - row {
//                                display: flex;
//                                    justify - content: space - between;
//                                padding: 9px 0;
//                                    border - bottom: 1px solid #F1F5F9;
//        font - size: 0.85rem;
//                                }
//    .info - row:last - child { border - bottom: none; }
//    .info - row.lbl {
//                                color: #64748B; }
//    .info - row.val {
//                                        font - weight: 600; color: #1E293B; text-align: right; }

//    .tag {
//                                        display: inline - flex;
//                                            align - items: center;
//                                        gap: 6px;
//                                        background: #F8FAFC;
//        border: 1px solid #E2E8F0;
//        padding: 6px 14px;
//                                            border - radius: 8px;
//                                            font - size: 0.78rem;
//                                        color: #1E293B;
//        transition: all 0.2s;
//                                        }
//    .tag: hover {
//                                        background: #DBEAFE;
//        border - color: #93C5FD;
//        color: #003366;
//    }
//    .tag i {
//                                        color: #003366; }
//</ style >

//< div class= "container-fluid px-4 py-4" >

//    < !-- ===== SELAMAT DATANG ===== -->
//    < div class= "welcome-section mb-4" >
//        < div class= "row align-items-center" >
//            < div class= "col-lg-8" >
//                < div class= "welcome-content" >
//                    < div class= "d-flex align-items-center gap-2 mb-3 flex-wrap" >
//                        < span class= "welcome-badge" >< i class= "bi bi-circle-fill" style = "font-size:0.55rem;color:#4ADE80;" ></ i > Sistem Aktif </ span >
//                        < span style = "font-size:0.75rem;color:rgba(255,255,255,0.5);" >|</ span >
//                        < span style = "font-size:0.75rem;color:rgba(255,255,255,0.6);" > PT Pos Indonesia Cabang Malangbong Garut</span>
//                    </div>
//                    <div class= "welcome-title mb-2" >
//                        Selamat Datang di Sistem Optimasi Rute
//                    </div>
//                    <div class= "welcome-sub" >
//                        Kelola data kiriman, atur penugasan, dan optimasi rute pengantaran
//                        paket & dokumen dengan algoritma ACO - 2 Opt.
//                    </div>
//                </div>
//            </div>
//            <div class= "col-lg-4 text-end d-none d-lg-block" >
//                < img src = "~/custom/Content/img/group.png" class= "welcome-img" alt = "ilustrasi" />
//            </ div >
//        </ div >
//    </ div >

//    < !-- ===== RINGKASAN ===== -->
//    < div class= "row g-3 mb-4" >
//        < div class= "col-6 col-md-3" >
//            < div class= "stat-box d-flex align-items-center gap-3" >
//                < div class= "stat-icon s-blue" >< i class= "bi bi-box-seam-fill" ></ i ></ div >
//                < div >
//                    < div class= "stat-num" > --</ div >
//                    < div class= "stat-label" > Total Kiriman </ div >
//                </ div >
//            </ div >
//        </ div >
//        < div class= "col-6 col-md-3" >
//            < div class= "stat-box d-flex align-items-center gap-3" >
//                < div class= "stat-icon s-orange" >< i class= "bi bi-truck" ></ i ></ div >
//                < div >
//                    < div class= "stat-num" > --</ div >
//                    < div class= "stat-label" > Penugasan Aktif </ div >
//                </ div >
//            </ div >
//        </ div >
//        < div class= "col-6 col-md-3" >
//            < div class= "stat-box d-flex align-items-center gap-3" >
//                < div class= "stat-icon s-green" >< i class= "bi bi-map" ></ i ></ div >
//                < div >
//                    < div class= "stat-num" > --</ div >
//                    < div class= "stat-label" > Rute Teroptimasi </ div >
//                </ div >
//            </ div >
//        </ div >
//        < div class= "col-6 col-md-3" >
//            < div class= "stat-box d-flex align-items-center gap-3" >
//                < div class= "stat-icon s-purple" >< i class= "bi bi-people-fill" ></ i ></ div >
//                < div >
//                    < div class= "stat-num" > --</ div >
//                    < div class= "stat-label" > Pengguna Aktif </ div >
//                </ div >
//            </ div >
//        </ div >
//    </ div >

//    < !-- ===== FITUR + INFO ===== -->
//    < div class= "row g-4" >

//        < div class= "col-lg-8" >

//            < div class= "d-flex align-items-end justify-content-between mb-3" >
//                < div >
//                    < div class= "section-label" > Fitur Utama </ div >
//                    < div class= "section-sub" > Akses cepat ke halaman utama sistem</div>
//                </div>
//            </div>

//            <div class= "row g-3 mb-4" >
//                < div class= "col-md-6" >
//                    < a href = "/datapaket" class= "menu-box" >
//                        < div class= "box-icon b-blue" >< i class= "bi bi-box-seam-fill" ></ i ></ div >
//                        < div class= "box-title" > Data Kiriman </ div >
//                        < div class= "box-desc" > Kelola data paket dan dokumen yang akan diantarkan.</div>
//                    </a>
//                </div>
//                <div class= "col-md-6" >
//                    < a href = "/ManajemenAntaran/PenugasanPengantaran" class= "menu-box" >
//                        < div class= "box-icon b-orange" >< i class= "bi bi-clipboard-check-fill" ></ i ></ div >
//                        < div class= "box-title" > Penugasan Pengantaran </ div >
//                        < div class= "box-desc" > Atur dan kelola penugasan kiriman ke petugas.</div>
//                    </a>
//                </div>
//                <div class= "col-md-6" >
//                    < a href = "/ManajemenAntaran/OptimasiPengantaran" class= "menu-box" >
//                        < div class= "box-icon b-green" >< i class= "bi bi-diagram-3-fill" ></ i ></ div >
//                        < div class= "box-title" > Optimasi Rute </ div >
//                        < div class= "box-desc" > Optimasi rute pengantaran dengan ACO & 2-Opt.</div>
//                    </a>
//                </div>
//                <div class= "col-md-6" >
//                    < a href = "/datamaster/LokasiKantor" class= "menu-box" >
//                        < div class= "box-icon b-purple" >< i class= "bi bi-database-fill-gear" ></ i ></ div >
//                        < div class= "box-title" > Data Master </ div >
//                        < div class= "box-desc" > Kelola master lokasi, layanan, dan jenis kiriman.</div>
//                    </a>
//                </div>
//            </div>

//            <div class= "info-card" >
//                < div class= "c-header" >< i class= "bi bi-stars" style = "color:#003366;" ></ i > Fitur Pendukung </ div >
//                < div class= "c-body" >
//                    < div class= "d-flex flex-wrap gap-2" >
//                        < span class= "tag" >< i class= "bi bi-geo-alt-fill" ></ i > Visualisasi Peta </ span >
//                        < span class= "tag" >< i class= "bi bi-cpu-fill" ></ i > ACO - 2 Opt </ span >
//                        < span class= "tag" >< i class= "bi bi-clock-history" ></ i > Estimasi Waktu </ span >
//                        < span class= "tag" >< i class= "bi bi-rulers" ></ i > Info Jarak Tempuh</span>
//                        <span class= "tag" >< i class= "bi bi-file-earmark-spreadsheet-fill" ></ i > Import Excel </ span >
//                        < span class= "tag" >< i class= "bi bi-printer-fill" ></ i > Cetak Laporan </ span >
//                    </ div >
//                </ div >
//            </ div >

//        </ div >

//        < div class= "col-lg-4" >

//            < div class= "info-card mb-3" >
//                < div class= "c-header" >< i class= "bi bi-info-circle-fill" style = "color:#003366;" ></ i > Informasi Sistem </ div >
//                < div class= "c-body" >
//                    < div class= "info-row" >
//                        < span class= "lbl" > Algoritma </ span >
//                        < span class= "val" > ACO - 2 Opt </ span >
//                    </ div >
//                    < div class= "info-row" >
//                        < span class= "lbl" > Lokasi </ span >
//                        < span class= "val" style = "max-width:155px;" > PT Pos Indonesia Cab. Malangbong Garut 44188</span>
//                    </div>
//                    <div class= "info-row" >
//                        < span class= "lbl" > Platform </ span >
//                        < span class= "val" > Web Application </ span >
//                    </ div >
//                    < div class= "info-row" >
//                        < span class= "lbl" > Framework </ span >
//                        < span class= "val" > ASP.NET Core 8</span>
//                    </div>
//                    <div class= "info-row" >
//                        < span class= "lbl" > Status </ span >
//                        < span class= "val" style = "color:#059669;" >< i class= "bi bi-check-circle-fill me-1" ></ i > Aktif </ span >
//                    </ div >
//                    < div class= "info-row" >
//                        < span class= "lbl" > Versi </ span >
//                        < span class= "val" > 1.0.0 </ span >
//                    </ div >
//                </ div >
//            </ div >

//            < div class= "info-card" >
//                < div class= "c-header" >< i class= "bi bi-book-fill" style = "color:#003366;" ></ i > Tentang Sistem </ div >
//                < div class= "c-body" >
//                    < p class= "text-muted mb-0" style = "font-size:0.85rem;line-height:1.7;" >
//                        Sistem optimasi rute pengantaran paket dan dokumen di lingkungan
//                        <strong>PT Pos Indonesia Cabang Malangbong Garut</strong>.
//                        Menggunakan algoritma <strong>Ant Colony Optimization (ACO)</strong>
//                        dan <strong>2-Opt</strong> untuk menghasilkan rute pengantaran optimal
//                        beserta informasi jarak tempuh dan estimasi waktu perjalanan.
//                    </p>
//                </div>
//            </div>

//        </div>

//    </div>

//</div>