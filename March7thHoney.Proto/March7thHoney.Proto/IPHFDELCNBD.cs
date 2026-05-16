using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IPHFDELCNBD : IMessage<IPHFDELCNBD>, IMessage, IEquatable<IPHFDELCNBD>, IDeepCloneable<IPHFDELCNBD>, IBufferMessage
{
	private static readonly MessageParser<IPHFDELCNBD> _parser = new MessageParser<IPHFDELCNBD>(() => new IPHFDELCNBD());

	private UnknownFieldSet _unknownFields;

	public const int BPHECFNCICCFieldNumber = 1;

	private KFOEEPGNDOC bPHECFNCICC_;

	public const int UniqueIdFieldNumber = 2;

	private uint uniqueId_;

	public const int SourceFieldNumber = 3;

	private MCAFGBPLFEH source_;

	public const int PEILPIEKLKDFieldNumber = 4;

	private double pEILPIEKLKD_;

	public const int HOKHMNGMHKAFieldNumber = 13;

	private double hOKHMNGMHKA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IPHFDELCNBD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IPHFDELCNBDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFOEEPGNDOC BPHECFNCICC
	{
		get
		{
			return bPHECFNCICC_;
		}
		set
		{
			bPHECFNCICC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCAFGBPLFEH Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double PEILPIEKLKD
	{
		get
		{
			return pEILPIEKLKD_;
		}
		set
		{
			pEILPIEKLKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double HOKHMNGMHKA
	{
		get
		{
			return hOKHMNGMHKA_;
		}
		set
		{
			hOKHMNGMHKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPHFDELCNBD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPHFDELCNBD(IPHFDELCNBD other)
		: this()
	{
		bPHECFNCICC_ = other.bPHECFNCICC_;
		uniqueId_ = other.uniqueId_;
		source_ = ((other.source_ != null) ? other.source_.Clone() : null);
		pEILPIEKLKD_ = other.pEILPIEKLKD_;
		hOKHMNGMHKA_ = other.hOKHMNGMHKA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPHFDELCNBD Clone()
	{
		return new IPHFDELCNBD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IPHFDELCNBD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IPHFDELCNBD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BPHECFNCICC != other.BPHECFNCICC)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!object.Equals(Source, other.Source))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PEILPIEKLKD, other.PEILPIEKLKD))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(HOKHMNGMHKA, other.HOKHMNGMHKA))
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
		if (BPHECFNCICC != KFOEEPGNDOC.Pcpdhelpkem)
		{
			num ^= BPHECFNCICC.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (source_ != null)
		{
			num ^= Source.GetHashCode();
		}
		if (PEILPIEKLKD != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PEILPIEKLKD);
		}
		if (HOKHMNGMHKA != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(HOKHMNGMHKA);
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
		if (BPHECFNCICC != KFOEEPGNDOC.Pcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)BPHECFNCICC);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(UniqueId);
		}
		if (source_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Source);
		}
		if (PEILPIEKLKD != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(PEILPIEKLKD);
		}
		if (HOKHMNGMHKA != 0.0)
		{
			output.WriteRawTag(105);
			output.WriteDouble(HOKHMNGMHKA);
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
		if (BPHECFNCICC != KFOEEPGNDOC.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BPHECFNCICC);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (source_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (PEILPIEKLKD != 0.0)
		{
			num += 9;
		}
		if (HOKHMNGMHKA != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IPHFDELCNBD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BPHECFNCICC != KFOEEPGNDOC.Pcpdhelpkem)
		{
			BPHECFNCICC = other.BPHECFNCICC;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.source_ != null)
		{
			if (source_ == null)
			{
				Source = new MCAFGBPLFEH();
			}
			Source.MergeFrom(other.Source);
		}
		if (other.PEILPIEKLKD != 0.0)
		{
			PEILPIEKLKD = other.PEILPIEKLKD;
		}
		if (other.HOKHMNGMHKA != 0.0)
		{
			HOKHMNGMHKA = other.HOKHMNGMHKA;
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
			case 8u:
				BPHECFNCICC = (KFOEEPGNDOC)input.ReadEnum();
				break;
			case 16u:
				UniqueId = input.ReadUInt32();
				break;
			case 26u:
				if (source_ == null)
				{
					Source = new MCAFGBPLFEH();
				}
				input.ReadMessage(Source);
				break;
			case 33u:
				PEILPIEKLKD = input.ReadDouble();
				break;
			case 105u:
				HOKHMNGMHKA = input.ReadDouble();
				break;
			}
		}
	}
}
