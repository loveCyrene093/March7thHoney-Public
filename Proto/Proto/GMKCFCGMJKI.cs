using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GMKCFCGMJKI : IMessage<GMKCFCGMJKI>, IMessage, IEquatable<GMKCFCGMJKI>, IDeepCloneable<GMKCFCGMJKI>, IBufferMessage
{
	private static readonly MessageParser<GMKCFCGMJKI> _parser = new MessageParser<GMKCFCGMJKI>(() => new GMKCFCGMJKI());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int EOGHMDEFBILFieldNumber = 11;

	private uint eOGHMDEFBIL_;

	public const int CKMHEIIFPAOFieldNumber = 12;

	private uint cKMHEIIFPAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GMKCFCGMJKI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GMKCFCGMJKIReflection.Descriptor.MessageTypes[0];

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
	public uint EOGHMDEFBIL
	{
		get
		{
			return eOGHMDEFBIL_;
		}
		set
		{
			eOGHMDEFBIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CKMHEIIFPAO
	{
		get
		{
			return cKMHEIIFPAO_;
		}
		set
		{
			cKMHEIIFPAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMKCFCGMJKI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMKCFCGMJKI(GMKCFCGMJKI other)
		: this()
	{
		avatarId_ = other.avatarId_;
		eOGHMDEFBIL_ = other.eOGHMDEFBIL_;
		cKMHEIIFPAO_ = other.cKMHEIIFPAO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMKCFCGMJKI Clone()
	{
		return new GMKCFCGMJKI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GMKCFCGMJKI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GMKCFCGMJKI other)
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
		if (EOGHMDEFBIL != other.EOGHMDEFBIL)
		{
			return false;
		}
		if (CKMHEIIFPAO != other.CKMHEIIFPAO)
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
		if (EOGHMDEFBIL != 0)
		{
			num ^= EOGHMDEFBIL.GetHashCode();
		}
		if (CKMHEIIFPAO != 0)
		{
			num ^= CKMHEIIFPAO.GetHashCode();
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
		if (EOGHMDEFBIL != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(EOGHMDEFBIL);
		}
		if (CKMHEIIFPAO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CKMHEIIFPAO);
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
		if (EOGHMDEFBIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EOGHMDEFBIL);
		}
		if (CKMHEIIFPAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CKMHEIIFPAO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GMKCFCGMJKI other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.EOGHMDEFBIL != 0)
			{
				EOGHMDEFBIL = other.EOGHMDEFBIL;
			}
			if (other.CKMHEIIFPAO != 0)
			{
				CKMHEIIFPAO = other.CKMHEIIFPAO;
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
			case 88u:
				EOGHMDEFBIL = input.ReadUInt32();
				break;
			case 96u:
				CKMHEIIFPAO = input.ReadUInt32();
				break;
			}
		}
	}
}
