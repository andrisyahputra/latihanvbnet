TYPE=VIEW
query=select `coba`.`tbl_pelanggan`.`id_pelanggan` AS `id_pelanggan`,`coba`.`tbl_pelanggan`.`nama_pelanggan` AS `nama_pelanggan`,`coba`.`tbl_pelanggan`.`type_pelanggan` AS `type_pelanggan`,`coba`.`tbl_pelanggan`.`id_kendaraan` AS `id_kendaraan`,`coba`.`tbl_kendaraan`.`tgl_kendaraan` AS `tgl_kendaraan`,`coba`.`tbl_kendaraan`.`tgl_jatuh_tempo` AS `tgl_jatuh_tempo` from `coba`.`tbl_pelanggan` join `coba`.`tbl_kendaraan` where `coba`.`tbl_pelanggan`.`id_kendaraan` = `coba`.`tbl_kendaraan`.`id_kendaraan`
md5=dfcd0612f22503b5905ac3c0e22b9c9f
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=0001677751693882296
create-version=2
source=SELECT\n`tbl_pelanggan`.`id_pelanggan`,\n`tbl_pelanggan`.`nama_pelanggan`,\n`tbl_pelanggan`.`type_pelanggan`,\n`tbl_pelanggan`.`id_kendaraan`,\n\n`tbl_kendaraan`.`tgl_kendaraan`,\n`tbl_kendaraan`.`tgl_jatuh_tempo`\nFROM\n`tbl_pelanggan`,`tbl_kendaraan`\nWHERE\n`tbl_pelanggan`.`id_kendaraan` = `tbl_kendaraan`.`id_kendaraan`
client_cs_name=utf8mb4
connection_cl_name=utf8mb4_unicode_ci
view_body_utf8=select `coba`.`tbl_pelanggan`.`id_pelanggan` AS `id_pelanggan`,`coba`.`tbl_pelanggan`.`nama_pelanggan` AS `nama_pelanggan`,`coba`.`tbl_pelanggan`.`type_pelanggan` AS `type_pelanggan`,`coba`.`tbl_pelanggan`.`id_kendaraan` AS `id_kendaraan`,`coba`.`tbl_kendaraan`.`tgl_kendaraan` AS `tgl_kendaraan`,`coba`.`tbl_kendaraan`.`tgl_jatuh_tempo` AS `tgl_jatuh_tempo` from `coba`.`tbl_pelanggan` join `coba`.`tbl_kendaraan` where `coba`.`tbl_pelanggan`.`id_kendaraan` = `coba`.`tbl_kendaraan`.`id_kendaraan`
mariadb-version=100427
