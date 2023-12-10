import java.io.FileNotFoundException;
import java.io.IOException;

public class ZeroNoFiles extends IOException {
    public ZeroNoFiles() {
        super("Файла нету!");
    }
}
