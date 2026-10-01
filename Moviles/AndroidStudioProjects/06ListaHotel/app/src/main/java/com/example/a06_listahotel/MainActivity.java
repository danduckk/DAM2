package com.example.a06_listahotel;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;


public class MainActivity extends AppCompatActivity implements CompoundButton.OnCheckedChangeListener {

    private CheckBox cbDesayuno;
    private CheckBox cbComida;
    private CheckBox cbCena;
    private TextView tvResultado;
    private Double resultado = 0.0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        cbDesayuno = findViewById(R.id.cbDesayuno);
        cbComida = findViewById(R.id.cbComida);
        cbCena = findViewById(R.id.cbCena);
        tvResultado = findViewById(R.id.tvResultado);

        cbDesayuno.setOnCheckedChangeListener(this);
        cbComida.setOnCheckedChangeListener(this);
        cbCena.setOnCheckedChangeListener(this);
    }

    @Override
    public void onCheckedChanged(@NonNull CompoundButton buttonView, boolean isChecked) {
        try {
            if (buttonView.getId() == R.id.cbDesayuno) {
                if (cbDesayuno.isChecked()) {
                    resultado += 10;
                    tvResultado.setText(resultado.toString());
                } else {
                    resultado -= 10;
                    tvResultado.setText(resultado.toString());
                }

            }
            if (buttonView.getId() == R.id.cbComida) {
                if (cbComida.isChecked()) {
                    resultado += 25;
                    tvResultado.setText(resultado.toString());
                } else {
                    resultado -= 25;
                    tvResultado.setText(resultado.toString());
                }

            }
            if (buttonView.getId() == R.id.cbCena) {
                if (cbCena.isChecked()) {
                    resultado += 30;
                    tvResultado.setText(resultado.toString());
                } else {
                    resultado -= 30;
                    tvResultado.setText(resultado.toString());
                }

            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}