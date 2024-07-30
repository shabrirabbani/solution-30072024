WITH LastStock AS (
    SELECT KodeBarang, StokAkhir, ROW_NUMBER() OVER (PARTITION BY KodeBarang ORDER BY Tanggal DESC, KodeStok DESC) AS rn
    FROM HistoriStokBarang
)
SELECT KodeBarang, StokAkhir
FROM LastStock
WHERE rn = 1
ORDER BY KodeBarang;