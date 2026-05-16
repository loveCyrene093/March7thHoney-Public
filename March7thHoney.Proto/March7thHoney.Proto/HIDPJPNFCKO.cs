using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HIDPJPNFCKO : IMessage<HIDPJPNFCKO>, IMessage, IEquatable<HIDPJPNFCKO>, IDeepCloneable<HIDPJPNFCKO>, IBufferMessage
{
	private static readonly MessageParser<HIDPJPNFCKO> _parser = new MessageParser<HIDPJPNFCKO>(() => new HIDPJPNFCKO());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int MMKJKGMIEAPFieldNumber = 2;

	private bool mMKJKGMIEAP_;

	public const int JFOAGNILNKKFieldNumber = 3;

	private bool jFOAGNILNKK_;

	public const int NFILAOLPOKEFieldNumber = 4;

	private bool nFILAOLPOKE_;

	public const int PJHDKDAFHJDFieldNumber = 5;

	private bool pJHDKDAFHJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HIDPJPNFCKO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HIDPJPNFCKOReflection.Descriptor.MessageTypes[0];

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
	public bool MMKJKGMIEAP
	{
		get
		{
			return mMKJKGMIEAP_;
		}
		set
		{
			mMKJKGMIEAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JFOAGNILNKK
	{
		get
		{
			return jFOAGNILNKK_;
		}
		set
		{
			jFOAGNILNKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NFILAOLPOKE
	{
		get
		{
			return nFILAOLPOKE_;
		}
		set
		{
			nFILAOLPOKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PJHDKDAFHJD
	{
		get
		{
			return pJHDKDAFHJD_;
		}
		set
		{
			pJHDKDAFHJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIDPJPNFCKO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIDPJPNFCKO(HIDPJPNFCKO other)
		: this()
	{
		avatarId_ = other.avatarId_;
		mMKJKGMIEAP_ = other.mMKJKGMIEAP_;
		jFOAGNILNKK_ = other.jFOAGNILNKK_;
		nFILAOLPOKE_ = other.nFILAOLPOKE_;
		pJHDKDAFHJD_ = other.pJHDKDAFHJD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HIDPJPNFCKO Clone()
	{
		return new HIDPJPNFCKO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HIDPJPNFCKO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HIDPJPNFCKO other)
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
		if (MMKJKGMIEAP != other.MMKJKGMIEAP)
		{
			return false;
		}
		if (JFOAGNILNKK != other.JFOAGNILNKK)
		{
			return false;
		}
		if (NFILAOLPOKE != other.NFILAOLPOKE)
		{
			return false;
		}
		if (PJHDKDAFHJD != other.PJHDKDAFHJD)
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
		if (MMKJKGMIEAP)
		{
			num ^= MMKJKGMIEAP.GetHashCode();
		}
		if (JFOAGNILNKK)
		{
			num ^= JFOAGNILNKK.GetHashCode();
		}
		if (NFILAOLPOKE)
		{
			num ^= NFILAOLPOKE.GetHashCode();
		}
		if (PJHDKDAFHJD)
		{
			num ^= PJHDKDAFHJD.GetHashCode();
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
		if (MMKJKGMIEAP)
		{
			output.WriteRawTag(16);
			output.WriteBool(MMKJKGMIEAP);
		}
		if (JFOAGNILNKK)
		{
			output.WriteRawTag(24);
			output.WriteBool(JFOAGNILNKK);
		}
		if (NFILAOLPOKE)
		{
			output.WriteRawTag(32);
			output.WriteBool(NFILAOLPOKE);
		}
		if (PJHDKDAFHJD)
		{
			output.WriteRawTag(40);
			output.WriteBool(PJHDKDAFHJD);
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
		if (MMKJKGMIEAP)
		{
			num += 2;
		}
		if (JFOAGNILNKK)
		{
			num += 2;
		}
		if (NFILAOLPOKE)
		{
			num += 2;
		}
		if (PJHDKDAFHJD)
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
	public void MergeFrom(HIDPJPNFCKO other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.MMKJKGMIEAP)
			{
				MMKJKGMIEAP = other.MMKJKGMIEAP;
			}
			if (other.JFOAGNILNKK)
			{
				JFOAGNILNKK = other.JFOAGNILNKK;
			}
			if (other.NFILAOLPOKE)
			{
				NFILAOLPOKE = other.NFILAOLPOKE;
			}
			if (other.PJHDKDAFHJD)
			{
				PJHDKDAFHJD = other.PJHDKDAFHJD;
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
			case 16u:
				MMKJKGMIEAP = input.ReadBool();
				break;
			case 24u:
				JFOAGNILNKK = input.ReadBool();
				break;
			case 32u:
				NFILAOLPOKE = input.ReadBool();
				break;
			case 40u:
				PJHDKDAFHJD = input.ReadBool();
				break;
			}
		}
	}
}
