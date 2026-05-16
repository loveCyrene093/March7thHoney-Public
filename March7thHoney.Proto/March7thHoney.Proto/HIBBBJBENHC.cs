using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HIBBBJBENHC : IMessage<HIBBBJBENHC>, IMessage, IEquatable<HIBBBJBENHC>, IDeepCloneable<HIBBBJBENHC>, IBufferMessage
{
	private static readonly MessageParser<HIBBBJBENHC> _parser = new MessageParser<HIBBBJBENHC>(() => new HIBBBJBENHC());

	private UnknownFieldSet _unknownFields;

	public const int MotionFieldNumber = 11;

	private MotionInfo motion_;

	public const int BIAGIFIKDNAFieldNumber = 12;

	private uint bIAGIFIKDNA_;

	public const int BLLLDCMOAAIFieldNumber = 13;

	private static readonly FieldCodec<Vector> _repeated_bLLLDCMOAAI_codec = FieldCodec.ForMessage(106u, Vector.Parser);

	private readonly RepeatedField<Vector> bLLLDCMOAAI_ = new RepeatedField<Vector>();

	public const int PIJMKHMDHAEFieldNumber = 14;

	private bool pIJMKHMDHAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HIBBBJBENHC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HIBBBJBENHCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo Motion
	{
		get
		{
			return motion_;
		}
		set
		{
			motion_ = value;
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
	public HIBBBJBENHC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIBBBJBENHC(HIBBBJBENHC other)
		: this()
	{
		motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
		bIAGIFIKDNA_ = other.bIAGIFIKDNA_;
		bLLLDCMOAAI_ = other.bLLLDCMOAAI_.Clone();
		pIJMKHMDHAE_ = other.pIJMKHMDHAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIBBBJBENHC Clone()
	{
		return new HIBBBJBENHC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HIBBBJBENHC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HIBBBJBENHC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Motion, other.Motion))
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
		if (PIJMKHMDHAE != other.PIJMKHMDHAE)
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
		if (motion_ != null)
		{
			num ^= Motion.GetHashCode();
		}
		if (BIAGIFIKDNA != 0)
		{
			num ^= BIAGIFIKDNA.GetHashCode();
		}
		num ^= bLLLDCMOAAI_.GetHashCode();
		if (PIJMKHMDHAE)
		{
			num ^= PIJMKHMDHAE.GetHashCode();
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
		if (motion_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(Motion);
		}
		if (BIAGIFIKDNA != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(BIAGIFIKDNA);
		}
		bLLLDCMOAAI_.WriteTo(ref output, _repeated_bLLLDCMOAAI_codec);
		if (PIJMKHMDHAE)
		{
			output.WriteRawTag(112);
			output.WriteBool(PIJMKHMDHAE);
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
		if (motion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Motion);
		}
		if (BIAGIFIKDNA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BIAGIFIKDNA);
		}
		num += bLLLDCMOAAI_.CalculateSize(_repeated_bLLLDCMOAAI_codec);
		if (PIJMKHMDHAE)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HIBBBJBENHC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.motion_ != null)
		{
			if (motion_ == null)
			{
				Motion = new MotionInfo();
			}
			Motion.MergeFrom(other.Motion);
		}
		if (other.BIAGIFIKDNA != 0)
		{
			BIAGIFIKDNA = other.BIAGIFIKDNA;
		}
		bLLLDCMOAAI_.Add(other.bLLLDCMOAAI_);
		if (other.PIJMKHMDHAE)
		{
			PIJMKHMDHAE = other.PIJMKHMDHAE;
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
			case 90u:
				if (motion_ == null)
				{
					Motion = new MotionInfo();
				}
				input.ReadMessage(Motion);
				break;
			case 96u:
				BIAGIFIKDNA = input.ReadUInt32();
				break;
			case 106u:
				bLLLDCMOAAI_.AddEntriesFrom(ref input, _repeated_bLLLDCMOAAI_codec);
				break;
			case 112u:
				PIJMKHMDHAE = input.ReadBool();
				break;
			}
		}
	}
}
