using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NJBHKLCKHBK : IMessage<NJBHKLCKHBK>, IMessage, IEquatable<NJBHKLCKHBK>, IDeepCloneable<NJBHKLCKHBK>, IBufferMessage
{
	private static readonly MessageParser<NJBHKLCKHBK> _parser = new MessageParser<NJBHKLCKHBK>(() => new NJBHKLCKHBK());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private uint id_;

	public const int PIJMKHMDHAEFieldNumber = 5;

	private bool pIJMKHMDHAE_;

	public const int BIAGIFIKDNAFieldNumber = 9;

	private uint bIAGIFIKDNA_;

	public const int BLLLDCMOAAIFieldNumber = 10;

	private static readonly FieldCodec<Vector> _repeated_bLLLDCMOAAI_codec = FieldCodec.ForMessage(82u, Vector.Parser);

	private readonly RepeatedField<Vector> bLLLDCMOAAI_ = new RepeatedField<Vector>();

	public const int UuidFieldNumber = 13;

	private string uuid_ = "";

	public const int CPEMLIAGBKBFieldNumber = 14;

	private HIBBBJBENHC cPEMLIAGBKB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NJBHKLCKHBK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NJBHKLCKHBKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PIJMKHMDHAE
	{
		get
		{
			return pIJMKHMDHAE_;
		}
		set
		{
			pIJMKHMDHAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BIAGIFIKDNA
	{
		get
		{
			return bIAGIFIKDNA_;
		}
		set
		{
			bIAGIFIKDNA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Vector> BLLLDCMOAAI => bLLLDCMOAAI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Uuid
	{
		get
		{
			return uuid_;
		}
		set
		{
			uuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIBBBJBENHC CPEMLIAGBKB
	{
		get
		{
			return cPEMLIAGBKB_;
		}
		set
		{
			cPEMLIAGBKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJBHKLCKHBK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJBHKLCKHBK(NJBHKLCKHBK other)
		: this()
	{
		id_ = other.id_;
		pIJMKHMDHAE_ = other.pIJMKHMDHAE_;
		bIAGIFIKDNA_ = other.bIAGIFIKDNA_;
		bLLLDCMOAAI_ = other.bLLLDCMOAAI_.Clone();
		uuid_ = other.uuid_;
		cPEMLIAGBKB_ = ((other.cPEMLIAGBKB_ != null) ? other.cPEMLIAGBKB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJBHKLCKHBK Clone()
	{
		return new NJBHKLCKHBK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NJBHKLCKHBK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NJBHKLCKHBK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (PIJMKHMDHAE != other.PIJMKHMDHAE)
		{
			return false;
		}
		if (BIAGIFIKDNA != other.BIAGIFIKDNA)
		{
			return false;
		}
		if (!bLLLDCMOAAI_.Equals(other.bLLLDCMOAAI_))
		{
			return false;
		}
		if (Uuid != other.Uuid)
		{
			return false;
		}
		if (!object.Equals(CPEMLIAGBKB, other.CPEMLIAGBKB))
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (PIJMKHMDHAE)
		{
			num ^= PIJMKHMDHAE.GetHashCode();
		}
		if (BIAGIFIKDNA != 0)
		{
			num ^= BIAGIFIKDNA.GetHashCode();
		}
		num ^= bLLLDCMOAAI_.GetHashCode();
		if (Uuid.Length != 0)
		{
			num ^= Uuid.GetHashCode();
		}
		if (cPEMLIAGBKB_ != null)
		{
			num ^= CPEMLIAGBKB.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Id);
		}
		if (PIJMKHMDHAE)
		{
			output.WriteRawTag(40);
			output.WriteBool(PIJMKHMDHAE);
		}
		if (BIAGIFIKDNA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BIAGIFIKDNA);
		}
		bLLLDCMOAAI_.WriteTo(ref output, _repeated_bLLLDCMOAAI_codec);
		if (Uuid.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(Uuid);
		}
		if (cPEMLIAGBKB_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(CPEMLIAGBKB);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (PIJMKHMDHAE)
		{
			num += 2;
		}
		if (BIAGIFIKDNA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BIAGIFIKDNA);
		}
		num += bLLLDCMOAAI_.CalculateSize(_repeated_bLLLDCMOAAI_codec);
		if (Uuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Uuid);
		}
		if (cPEMLIAGBKB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CPEMLIAGBKB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NJBHKLCKHBK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.PIJMKHMDHAE)
		{
			PIJMKHMDHAE = other.PIJMKHMDHAE;
		}
		if (other.BIAGIFIKDNA != 0)
		{
			BIAGIFIKDNA = other.BIAGIFIKDNA;
		}
		bLLLDCMOAAI_.Add(other.bLLLDCMOAAI_);
		if (other.Uuid.Length != 0)
		{
			Uuid = other.Uuid;
		}
		if (other.cPEMLIAGBKB_ != null)
		{
			if (cPEMLIAGBKB_ == null)
			{
				CPEMLIAGBKB = new HIBBBJBENHC();
			}
			CPEMLIAGBKB.MergeFrom(other.CPEMLIAGBKB);
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
				Id = input.ReadUInt32();
				break;
			case 40u:
				PIJMKHMDHAE = input.ReadBool();
				break;
			case 72u:
				BIAGIFIKDNA = input.ReadUInt32();
				break;
			case 82u:
				bLLLDCMOAAI_.AddEntriesFrom(ref input, _repeated_bLLLDCMOAAI_codec);
				break;
			case 106u:
				Uuid = input.ReadString();
				break;
			case 114u:
				if (cPEMLIAGBKB_ == null)
				{
					CPEMLIAGBKB = new HIBBBJBENHC();
				}
				input.ReadMessage(CPEMLIAGBKB);
				break;
			}
		}
	}
}
