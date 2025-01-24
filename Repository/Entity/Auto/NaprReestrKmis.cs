using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity.Auto
{
    public class NaprReestrKmis
    
    {
        public NaprReestrKmis() { }
        public NaprReestrKmis(string _reestr_id, string _formpom, string _fio_d, string _kod, string _tipoplat, string _staconly, string _step, string _tipdpfs, string _sdpfs,
            string _ndpfs, string _st_okato, string _ogrnsmo, string _fam, string _im, string _ot, string _pol, string _drojd, string _telefon, string _kodamb, string _rnotdelamb,
            string _rnpodramb, string _nnapr, string _dnapr, string _profot, string _profil_k, string _formamp, string _mkbnapr, string _uslok, string _kodstac, string _dgospplan,
            string _rnotdelstac, string _rnpodrstac, string _mkbpo, string _nib, string _dgospfakt, string _vrgospfakt, string _dvyb, string _ishod, string _plandlitgosp,
            string _name_xml, string _status, string _id, string _rnvrachamb, string _pathPdf, bool _isLoad)
        {
            reestr_id = _reestr_id;
            formpom = _formpom;
            fio_d = _fio_d;
            kod = _kod;
            tipoplat = _tipoplat;
            stacolny = _staconly;
            step = _step;
            tipdpfs = _tipdpfs;
            sdpfs = _sdpfs;
            ndpfs = _ndpfs;
            st_okato = _st_okato;
            ogrnsmo = _ogrnsmo;
            fam = _fam;
            im = _im;
            ot = _ot;
            pol = _pol;
            drojd = _drojd;
            telefon = _telefon;
            kodamb = _kodamb;
            rnotdelamb = _rnotdelamb;
            rnpodramb = _rnpodramb;
            nnapr = _nnapr;
            dnapr = _dnapr;
            profot = _profot;
            profil_k = _profil_k;
            formamp = _formamp;
            mkbnapr = _mkbnapr;
            uslok = _uslok;
            kodstac = _kodstac;
            dgospplan = _dgospplan;
            rnotdelstac = _rnotdelstac;
            rnpodrstac = _rnpodrstac;
            mkbpo = _mkbpo;
            nib = _nib;
            dgospfakt = _dgospfakt;
            vrgospfakt = _vrgospfakt;
            dvyb = _dvyb;
            ishod = _ishod;
            plandlitgosp = _plandlitgosp;
            name_xml = _name_xml;
            status = _status;
            id = _id;
            rnvrachamb = _rnvrachamb;
            pathPdf = _pathPdf;
            isLoad = _isLoad;
        }

        public string reestr_id { get; set; }
        public string formpom { get; set; }
        public string filtr { get; set; }
        public string fio_d { get; set; }
        public string kod { get; set; }
        public string tipoplat { get; set; }
        public string stacolny { get; set; }
        public string step { get; set; }
        public string id { get; set; }
        public string tipdpfs { get; set; }
        public string sdpfs { get; set; }
        public string ndpfs { get; set; }
        public string st_okato { get; set; }
        public string ogrnsmo { get; set; }
        public string fam { get; set; }
        public string im { get; set; }
        public string ot { get; set; }
        public string pol { get; set; }
        public string drojd { get; set; }
        public string telefon { get; set; }
        public string kodamb { get; set; }
        public string rnotdelamb { get; set; }
        public string rnpodramb { get; set; }
        public string rnvrachamb { get; set; }
        public string nnapr { get; set; }
        public string dnapr { get; set; }
        public string profot { get; set; }
        public string profil_k { get; set; }
        public string formamp { get; set; }
        public string mkbnapr { get; set; }
        public string uslok { get; set; }
        public string kodstac { get; set; }
        public string dgospplan { get; set; }
        public string rnotdelstac { get; set; }
        public string rnpodrstac { get; set; }
        public string mkbpo { get; set; }
        public string nib { get; set; }
        public string dgospfakt { get; set; }
        public string vrgospfakt { get; set; }
        public string dvyb { get; set; }
        public string ishod { get; set; }
        public string plandlitgosp { get; set; }
        public string name_xml { get; set; }
        public string status { get; set; }
        public string pathPdf { get; set; }
        public bool isLoad { get; set; }
    }
}
