using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KEDAOINEEOB : IMessage<KEDAOINEEOB>, IMessage, IEquatable<KEDAOINEEOB>, IDeepCloneable<KEDAOINEEOB>, IBufferMessage
{
	private static readonly MessageParser<KEDAOINEEOB> _parser = new MessageParser<KEDAOINEEOB>(() => new KEDAOINEEOB());

	private UnknownFieldSet _unknownFields;

	public const int FLBFBBJIJIIFieldNumber = 3;

	private string fLBFBBJIJII_ = "";

	public const int HNHIGHGKECNFieldNumber = 13;

	private string hNHIGHGKECN_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KEDAOINEEOB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KEDAOINEEOBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FLBFBBJIJII
	{
		get
		{
			return fLBFBBJIJII_;
		}
		set
		{
			fLBFBBJIJII_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string HNHIGHGKECN
	{
		get
		{
			return hNHIGHGKECN_;
		}
		set
		{
			hNHIGHGKECN_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEDAOINEEOB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEDAOINEEOB(KEDAOINEEOB other)
		: this()
	{
		fLBFBBJIJII_ = other.fLBFBBJIJII_;
		hNHIGHGKECN_ = other.hNHIGHGKECN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEDAOINEEOB Clone()
	{
		return new KEDAOINEEOB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KEDAOINEEOB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KEDAOINEEOB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FLBFBBJIJII != other.FLBFBBJIJII)
		{
			return false;
		}
		if (HNHIGHGKECN != other.HNHIGHGKECN)
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
		if (FLBFBBJIJII.Length != 0)
		{
			num ^= FLBFBBJIJII.GetHashCode();
		}
		if (HNHIGHGKECN.Length != 0)
		{
			num ^= HNHIGHGKECN.GetHashCode();
		}
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
		if (FLBFBBJIJII.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(FLBFBBJIJII);
		}
		if (HNHIGHGKECN.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(HNHIGHGKECN);
		}
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
		if (FLBFBBJIJII.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FLBFBBJIJII);
		}
		if (HNHIGHGKECN.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HNHIGHGKECN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KEDAOINEEOB other)
	{
		if (other != null)
		{
			if (other.FLBFBBJIJII.Length != 0)
			{
				FLBFBBJIJII = other.FLBFBBJIJII;
			}
			if (other.HNHIGHGKECN.Length != 0)
			{
				HNHIGHGKECN = other.HNHIGHGKECN;
			}
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				FLBFBBJIJII = input.ReadString();
				break;
			case 106u:
				HNHIGHGKECN = input.ReadString();
				break;
			}
		}
	}
}
