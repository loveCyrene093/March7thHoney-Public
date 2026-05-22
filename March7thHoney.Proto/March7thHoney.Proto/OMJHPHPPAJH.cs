using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OMJHPHPPAJH : IMessage<OMJHPHPPAJH>, IMessage, IEquatable<OMJHPHPPAJH>, IDeepCloneable<OMJHPHPPAJH>, IBufferMessage
{
	private static readonly MessageParser<OMJHPHPPAJH> _parser = new MessageParser<OMJHPHPPAJH>(() => new OMJHPHPPAJH());

	private UnknownFieldSet _unknownFields;

	public const int FLBFBBJIJIIFieldNumber = 5;

	private string fLBFBBJIJII_ = "";

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int HNHIGHGKECNFieldNumber = 15;

	private string hNHIGHGKECN_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OMJHPHPPAJH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OMJHPHPPAJHReflection.Descriptor.MessageTypes[0];

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
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
	public OMJHPHPPAJH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMJHPHPPAJH(OMJHPHPPAJH other)
		: this()
	{
		fLBFBBJIJII_ = other.fLBFBBJIJII_;
		retcode_ = other.retcode_;
		hNHIGHGKECN_ = other.hNHIGHGKECN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OMJHPHPPAJH Clone()
	{
		return new OMJHPHPPAJH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OMJHPHPPAJH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OMJHPHPPAJH other)
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
		if (Retcode != other.Retcode)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
			output.WriteRawTag(42);
			output.WriteString(FLBFBBJIJII);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (HNHIGHGKECN.Length != 0)
		{
			output.WriteRawTag(122);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
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
	public void MergeFrom(OMJHPHPPAJH other)
	{
		if (other != null)
		{
			if (other.FLBFBBJIJII.Length != 0)
			{
				FLBFBBJIJII = other.FLBFBBJIJII;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 42u:
				FLBFBBJIJII = input.ReadString();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 122u:
				HNHIGHGKECN = input.ReadString();
				break;
			}
		}
	}
}
