﻿namespace CrownForecaster.Tools.ExchangeRatesImporter;

public interface IFxRateHistoricalDataFileWriter
{
    Task WriteToFile(FxRateHistoricalData historicalData, string path);
}
