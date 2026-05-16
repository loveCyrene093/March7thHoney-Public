using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MJEDAOPDIPM : IMessage<MJEDAOPDIPM>, IMessage, IEquatable<MJEDAOPDIPM>, IDeepCloneable<MJEDAOPDIPM>, IBufferMessage
{
	private static readonly MessageParser<MJEDAOPDIPM> _parser = new MessageParser<MJEDAOPDIPM>(() => new MJEDAOPDIPM());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int BKKDHHEDLAJFieldNumber = 2;

	private static readonly FieldCodec<MOGDMGICIKI> _repeated_bKKDHHEDLAJ_codec = FieldCodec.ForMessage(18u, MOGDMGICIKI.Parser);

	private readonly RepeatedField<MOGDMGICIKI> bKKDHHEDLAJ_ = new RepeatedField<MOGDMGICIKI>();

	public const int PCLHLNCJPHLFieldNumber = 3;

	private uint pCLHLNCJPHL_;

	public const int EJKPCFEPAECFieldNumber = 4;

	private uint eJKPCFEPAEC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MJEDAOPDIPM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MJEDAOPDIPMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MOGDMGICIKI> BKKDHHEDLAJ => bKKDHHEDLAJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PCLHLNCJPHL
	{
		get
		{
			return pCLHLNCJPHL_;
		}
		set
		{
			pCLHLNCJPHL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EJKPCFEPAEC
	{
		get
		{
			return eJKPCFEPAEC_;
		}
		set
		{
			eJKPCFEPAEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJEDAOPDIPM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJEDAOPDIPM(MJEDAOPDIPM other)
		: this()
	{
		avatarId_ = other.avatarId_;
		bKKDHHEDLAJ_ = other.bKKDHHEDLAJ_.Clone();
		pCLHLNCJPHL_ = other.pCLHLNCJPHL_;
		eJKPCFEPAEC_ = other.eJKPCFEPAEC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJEDAOPDIPM Clone()
	{
		return new MJEDAOPDIPM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MJEDAOPDIPM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MJEDAOPDIPM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!bKKDHHEDLAJ_.Equals(other.bKKDHHEDLAJ_))
		{
			return false;
		}
		if (PCLHLNCJPHL != other.PCLHLNCJPHL)
		{
			return false;
		}
		if (EJKPCFEPAEC != other.EJKPCFEPAEC)
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		num ^= bKKDHHEDLAJ_.GetHashCode();
		if (PCLHLNCJPHL != 0)
		{
			num ^= PCLHLNCJPHL.GetHashCode();
		}
		if (EJKPCFEPAEC != 0)
		{
			num ^= EJKPCFEPAEC.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		bKKDHHEDLAJ_.WriteTo(ref output, _repeated_bKKDHHEDLAJ_codec);
		if (PCLHLNCJPHL != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PCLHLNCJPHL);
		}
		if (EJKPCFEPAEC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EJKPCFEPAEC);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		num += bKKDHHEDLAJ_.CalculateSize(_repeated_bKKDHHEDLAJ_codec);
		if (PCLHLNCJPHL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PCLHLNCJPHL);
		}
		if (EJKPCFEPAEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EJKPCFEPAEC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MJEDAOPDIPM other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			bKKDHHEDLAJ_.Add(other.bKKDHHEDLAJ_);
			if (other.PCLHLNCJPHL != 0)
			{
				PCLHLNCJPHL = other.PCLHLNCJPHL;
			}
			if (other.EJKPCFEPAEC != 0)
			{
				EJKPCFEPAEC = other.EJKPCFEPAEC;
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
				AvatarId = input.ReadUInt32();
				break;
			case 18u:
				bKKDHHEDLAJ_.AddEntriesFrom(ref input, _repeated_bKKDHHEDLAJ_codec);
				break;
			case 24u:
				PCLHLNCJPHL = input.ReadUInt32();
				break;
			case 32u:
				EJKPCFEPAEC = input.ReadUInt32();
				break;
			}
		}
	}
}
