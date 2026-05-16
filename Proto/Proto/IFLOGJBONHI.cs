using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFLOGJBONHI : IMessage<IFLOGJBONHI>, IMessage, IEquatable<IFLOGJBONHI>, IDeepCloneable<IFLOGJBONHI>, IBufferMessage
{
	private static readonly MessageParser<IFLOGJBONHI> _parser = new MessageParser<IFLOGJBONHI>(() => new IFLOGJBONHI());

	private UnknownFieldSet _unknownFields;

	public const int MGNGPGPPIAAFieldNumber = 1;

	private uint mGNGPGPPIAA_;

	public const int GIOPMBAJENKFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_gIOPMBAJENK_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> gIOPMBAJENK_ = new RepeatedField<uint>();

	public const int JKPGACLKEECFieldNumber = 3;

	private uint jKPGACLKEEC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFLOGJBONHI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFLOGJBONHIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGNGPGPPIAA
	{
		get
		{
			return mGNGPGPPIAA_;
		}
		set
		{
			mGNGPGPPIAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GIOPMBAJENK => gIOPMBAJENK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKPGACLKEEC
	{
		get
		{
			return jKPGACLKEEC_;
		}
		set
		{
			jKPGACLKEEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFLOGJBONHI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFLOGJBONHI(IFLOGJBONHI other)
		: this()
	{
		mGNGPGPPIAA_ = other.mGNGPGPPIAA_;
		gIOPMBAJENK_ = other.gIOPMBAJENK_.Clone();
		jKPGACLKEEC_ = other.jKPGACLKEEC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFLOGJBONHI Clone()
	{
		return new IFLOGJBONHI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFLOGJBONHI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFLOGJBONHI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MGNGPGPPIAA != other.MGNGPGPPIAA)
		{
			return false;
		}
		if (!gIOPMBAJENK_.Equals(other.gIOPMBAJENK_))
		{
			return false;
		}
		if (JKPGACLKEEC != other.JKPGACLKEEC)
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
		if (MGNGPGPPIAA != 0)
		{
			num ^= MGNGPGPPIAA.GetHashCode();
		}
		num ^= gIOPMBAJENK_.GetHashCode();
		if (JKPGACLKEEC != 0)
		{
			num ^= JKPGACLKEEC.GetHashCode();
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
		if (MGNGPGPPIAA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MGNGPGPPIAA);
		}
		gIOPMBAJENK_.WriteTo(ref output, _repeated_gIOPMBAJENK_codec);
		if (JKPGACLKEEC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JKPGACLKEEC);
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
		if (MGNGPGPPIAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGNGPGPPIAA);
		}
		num += gIOPMBAJENK_.CalculateSize(_repeated_gIOPMBAJENK_codec);
		if (JKPGACLKEEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKPGACLKEEC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFLOGJBONHI other)
	{
		if (other != null)
		{
			if (other.MGNGPGPPIAA != 0)
			{
				MGNGPGPPIAA = other.MGNGPGPPIAA;
			}
			gIOPMBAJENK_.Add(other.gIOPMBAJENK_);
			if (other.JKPGACLKEEC != 0)
			{
				JKPGACLKEEC = other.JKPGACLKEEC;
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
			case 8u:
				MGNGPGPPIAA = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				gIOPMBAJENK_.AddEntriesFrom(ref input, _repeated_gIOPMBAJENK_codec);
				break;
			case 24u:
				JKPGACLKEEC = input.ReadUInt32();
				break;
			}
		}
	}
}
