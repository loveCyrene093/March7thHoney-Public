using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KJHFGPANMFH : IMessage<KJHFGPANMFH>, IMessage, IEquatable<KJHFGPANMFH>, IDeepCloneable<KJHFGPANMFH>, IBufferMessage
{
	private static readonly MessageParser<KJHFGPANMFH> _parser = new MessageParser<KJHFGPANMFH>(() => new KJHFGPANMFH());

	private UnknownFieldSet _unknownFields;

	public const int HMIBJHDMLNBFieldNumber = 3;

	private uint hMIBJHDMLNB_;

	public const int KGKOHNAACENFieldNumber = 4;

	private HHOKEJLGOBN kGKOHNAACEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KJHFGPANMFH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KJHFGPANMFHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HMIBJHDMLNB
	{
		get
		{
			return hMIBJHDMLNB_;
		}
		set
		{
			hMIBJHDMLNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHOKEJLGOBN KGKOHNAACEN
	{
		get
		{
			return kGKOHNAACEN_;
		}
		set
		{
			kGKOHNAACEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJHFGPANMFH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJHFGPANMFH(KJHFGPANMFH other)
		: this()
	{
		hMIBJHDMLNB_ = other.hMIBJHDMLNB_;
		kGKOHNAACEN_ = ((other.kGKOHNAACEN_ != null) ? other.kGKOHNAACEN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KJHFGPANMFH Clone()
	{
		return new KJHFGPANMFH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KJHFGPANMFH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KJHFGPANMFH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HMIBJHDMLNB != other.HMIBJHDMLNB)
		{
			return false;
		}
		if (!object.Equals(KGKOHNAACEN, other.KGKOHNAACEN))
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
		if (HMIBJHDMLNB != 0)
		{
			num ^= HMIBJHDMLNB.GetHashCode();
		}
		if (kGKOHNAACEN_ != null)
		{
			num ^= KGKOHNAACEN.GetHashCode();
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
		if (HMIBJHDMLNB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HMIBJHDMLNB);
		}
		if (kGKOHNAACEN_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(KGKOHNAACEN);
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
		if (HMIBJHDMLNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HMIBJHDMLNB);
		}
		if (kGKOHNAACEN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KGKOHNAACEN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KJHFGPANMFH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.HMIBJHDMLNB != 0)
		{
			HMIBJHDMLNB = other.HMIBJHDMLNB;
		}
		if (other.kGKOHNAACEN_ != null)
		{
			if (kGKOHNAACEN_ == null)
			{
				KGKOHNAACEN = new HHOKEJLGOBN();
			}
			KGKOHNAACEN.MergeFrom(other.KGKOHNAACEN);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 24u:
				HMIBJHDMLNB = input.ReadUInt32();
				break;
			case 34u:
				if (kGKOHNAACEN_ == null)
				{
					KGKOHNAACEN = new HHOKEJLGOBN();
				}
				input.ReadMessage(KGKOHNAACEN);
				break;
			}
		}
	}
}
