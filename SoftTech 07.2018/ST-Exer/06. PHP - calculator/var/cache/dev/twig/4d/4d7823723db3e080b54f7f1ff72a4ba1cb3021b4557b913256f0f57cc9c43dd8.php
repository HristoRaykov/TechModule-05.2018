<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_99b2a225cb70aa4a8d48984f92fa0c34ec0fea32a96ff1e63d94ed7465a2ded8 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_8b0705dfd8c13158cba2c165dc5d3a475b6d604ffdbadd778fc4af0ed1126abb = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8b0705dfd8c13158cba2c165dc5d3a475b6d604ffdbadd778fc4af0ed1126abb->enter($__internal_8b0705dfd8c13158cba2c165dc5d3a475b6d604ffdbadd778fc4af0ed1126abb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_853ad999ab6d40f072da9c8d588f2b3f6fc001be3b796aeeda5ab77a47700b96 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_853ad999ab6d40f072da9c8d588f2b3f6fc001be3b796aeeda5ab77a47700b96->enter($__internal_853ad999ab6d40f072da9c8d588f2b3f6fc001be3b796aeeda5ab77a47700b96_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_8b0705dfd8c13158cba2c165dc5d3a475b6d604ffdbadd778fc4af0ed1126abb->leave($__internal_8b0705dfd8c13158cba2c165dc5d3a475b6d604ffdbadd778fc4af0ed1126abb_prof);

        
        $__internal_853ad999ab6d40f072da9c8d588f2b3f6fc001be3b796aeeda5ab77a47700b96->leave($__internal_853ad999ab6d40f072da9c8d588f2b3f6fc001be3b796aeeda5ab77a47700b96_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_30efde1a5a784b6ba1c0e8b98f5e5575d70d9aef38cd361834cca2991cf94568 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_30efde1a5a784b6ba1c0e8b98f5e5575d70d9aef38cd361834cca2991cf94568->enter($__internal_30efde1a5a784b6ba1c0e8b98f5e5575d70d9aef38cd361834cca2991cf94568_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_1022693af4f1637b84ae8405c0c00416e3fa749e4c5d4918a2e2e64fd9ac11e0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1022693af4f1637b84ae8405c0c00416e3fa749e4c5d4918a2e2e64fd9ac11e0->enter($__internal_1022693af4f1637b84ae8405c0c00416e3fa749e4c5d4918a2e2e64fd9ac11e0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_1022693af4f1637b84ae8405c0c00416e3fa749e4c5d4918a2e2e64fd9ac11e0->leave($__internal_1022693af4f1637b84ae8405c0c00416e3fa749e4c5d4918a2e2e64fd9ac11e0_prof);

        
        $__internal_30efde1a5a784b6ba1c0e8b98f5e5575d70d9aef38cd361834cca2991cf94568->leave($__internal_30efde1a5a784b6ba1c0e8b98f5e5575d70d9aef38cd361834cca2991cf94568_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_d680939bdb2f7076264bdb5c820a5d82b3f067587bd0c606d16b1781fa4970bc = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d680939bdb2f7076264bdb5c820a5d82b3f067587bd0c606d16b1781fa4970bc->enter($__internal_d680939bdb2f7076264bdb5c820a5d82b3f067587bd0c606d16b1781fa4970bc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_69494e492b186172b91ce035007f0592e8029cae37fe1faf2a7a98e0f6272472 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_69494e492b186172b91ce035007f0592e8029cae37fe1faf2a7a98e0f6272472->enter($__internal_69494e492b186172b91ce035007f0592e8029cae37fe1faf2a7a98e0f6272472_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_69494e492b186172b91ce035007f0592e8029cae37fe1faf2a7a98e0f6272472->leave($__internal_69494e492b186172b91ce035007f0592e8029cae37fe1faf2a7a98e0f6272472_prof);

        
        $__internal_d680939bdb2f7076264bdb5c820a5d82b3f067587bd0c606d16b1781fa4970bc->leave($__internal_d680939bdb2f7076264bdb5c820a5d82b3f067587bd0c606d16b1781fa4970bc_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_fd3b0cd9a069462dcd7e6701d98b946af8ca3b6f15273648f01cb14633a23aa8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_fd3b0cd9a069462dcd7e6701d98b946af8ca3b6f15273648f01cb14633a23aa8->enter($__internal_fd3b0cd9a069462dcd7e6701d98b946af8ca3b6f15273648f01cb14633a23aa8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_aada3c88b3ba383995e63823ea56b95b0063ef7217d17eb02c2556e9295fab3b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_aada3c88b3ba383995e63823ea56b95b0063ef7217d17eb02c2556e9295fab3b->enter($__internal_aada3c88b3ba383995e63823ea56b95b0063ef7217d17eb02c2556e9295fab3b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_aada3c88b3ba383995e63823ea56b95b0063ef7217d17eb02c2556e9295fab3b->leave($__internal_aada3c88b3ba383995e63823ea56b95b0063ef7217d17eb02c2556e9295fab3b_prof);

        
        $__internal_fd3b0cd9a069462dcd7e6701d98b946af8ca3b6f15273648f01cb14633a23aa8->leave($__internal_fd3b0cd9a069462dcd7e6701d98b946af8ca3b6f15273648f01cb14633a23aa8_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "C:\\xampp\\htdocs\\MyProjects\\PHP-Calculator\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
