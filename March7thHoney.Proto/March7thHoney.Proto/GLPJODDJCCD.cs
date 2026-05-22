using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GLPJODDJCCD : IMessage<GLPJODDJCCD>, IMessage, IEquatable<GLPJODDJCCD>, IDeepCloneable<GLPJODDJCCD>, IBufferMessage
{
	private static readonly MessageParser<GLPJODDJCCD> _parser = new MessageParser<GLPJODDJCCD>(() => new GLPJODDJCCD());

	private UnknownFieldSet _unknownFields;

	public const int JDEANJMIKMLFieldNumber = 14;

	private static readonly FieldCodec<FPKALFNABLG> _repeated_jDEANJMIKML_codec = FieldCodec.ForMessage(114u, FPKALFNABLG.Parser);

	private readonly RepeatedField<FPKALFNABLG> jDEANJMIKML_ = new RepeatedField<FPKALFNABLG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GLPJODDJCCD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GLPJODDJCCDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FPKALFNABLG> JDEANJMIKML => jDEANJMIKML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLPJODDJCCD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLPJODDJCCD(GLPJODDJCCD other)
		: this()
	{
		jDEANJMIKML_ = other.jDEANJMIKML_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLPJODDJCCD Clone()
	{
		return new GLPJODDJCCD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GLPJODDJCCD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GLPJODDJCCD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jDEANJMIKML_.Equals(other.jDEANJMIKML_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		num ^= jDEANJMIKML_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		jDEANJMIKML_.WriteTo(ref output, _repeated_jDEANJMIKML_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		num += jDEANJMIKML_.CalculateSize(_repeated_jDEANJMIKML_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GLPJODDJCCD other)
	{
		if (other != null)
		{
			jDEANJMIKML_.Add(other.jDEANJMIKML_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				jDEANJMIKML_.AddEntriesFrom(ref input, _repeated_jDEANJMIKML_codec);
			}
		}
	}
}
