using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MACJBIAFNOI : IMessage<MACJBIAFNOI>, IMessage, IEquatable<MACJBIAFNOI>, IDeepCloneable<MACJBIAFNOI>, IBufferMessage
{
	private static readonly MessageParser<MACJBIAFNOI> _parser = new MessageParser<MACJBIAFNOI>(() => new MACJBIAFNOI());

	private UnknownFieldSet _unknownFields;

	public const int PosFieldNumber = 1;

	private Vector pos_;

	public const int RotFieldNumber = 2;

	private Vector rot_;

	public const int GNGKNDCKKKCFieldNumber = 3;

	private float gNGKNDCKKKC_;

	public const int NALBEFMOKIBFieldNumber = 4;

	private Vector nALBEFMOKIB_;

	public const int DCBBKFFHHDLFieldNumber = 5;

	private float dCBBKFFHHDL_;

	public const int JCBGHAODNDDFieldNumber = 6;

	private uint jCBGHAODNDD_;

	public const int MEKPIHJKJBLFieldNumber = 7;

	private bool mEKPIHJKJBL_;

	public const int KHAJDKDHPGDFieldNumber = 8;

	private long kHAJDKDHPGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MACJBIAFNOI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MACJBIAFNOIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector Rot
	{
		get
		{
			return rot_;
		}
		set
		{
			rot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float GNGKNDCKKKC
	{
		get
		{
			return gNGKNDCKKKC_;
		}
		set
		{
			gNGKNDCKKKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Vector NALBEFMOKIB
	{
		get
		{
			return nALBEFMOKIB_;
		}
		set
		{
			nALBEFMOKIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float DCBBKFFHHDL
	{
		get
		{
			return dCBBKFFHHDL_;
		}
		set
		{
			dCBBKFFHHDL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JCBGHAODNDD
	{
		get
		{
			return jCBGHAODNDD_;
		}
		set
		{
			jCBGHAODNDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MEKPIHJKJBL
	{
		get
		{
			return mEKPIHJKJBL_;
		}
		set
		{
			mEKPIHJKJBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long KHAJDKDHPGD
	{
		get
		{
			return kHAJDKDHPGD_;
		}
		set
		{
			kHAJDKDHPGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MACJBIAFNOI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MACJBIAFNOI(MACJBIAFNOI other)
		: this()
	{
		pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
		rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
		gNGKNDCKKKC_ = other.gNGKNDCKKKC_;
		nALBEFMOKIB_ = ((other.nALBEFMOKIB_ != null) ? other.nALBEFMOKIB_.Clone() : null);
		dCBBKFFHHDL_ = other.dCBBKFFHHDL_;
		jCBGHAODNDD_ = other.jCBGHAODNDD_;
		mEKPIHJKJBL_ = other.mEKPIHJKJBL_;
		kHAJDKDHPGD_ = other.kHAJDKDHPGD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MACJBIAFNOI Clone()
	{
		return new MACJBIAFNOI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MACJBIAFNOI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MACJBIAFNOI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Pos, other.Pos))
		{
			return false;
		}
		if (!object.Equals(Rot, other.Rot))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GNGKNDCKKKC, other.GNGKNDCKKKC))
		{
			return false;
		}
		if (!object.Equals(NALBEFMOKIB, other.NALBEFMOKIB))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DCBBKFFHHDL, other.DCBBKFFHHDL))
		{
			return false;
		}
		if (JCBGHAODNDD != other.JCBGHAODNDD)
		{
			return false;
		}
		if (MEKPIHJKJBL != other.MEKPIHJKJBL)
		{
			return false;
		}
		if (KHAJDKDHPGD != other.KHAJDKDHPGD)
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
		if (pos_ != null)
		{
			num ^= Pos.GetHashCode();
		}
		if (rot_ != null)
		{
			num ^= Rot.GetHashCode();
		}
		if (GNGKNDCKKKC != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GNGKNDCKKKC);
		}
		if (nALBEFMOKIB_ != null)
		{
			num ^= NALBEFMOKIB.GetHashCode();
		}
		if (DCBBKFFHHDL != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DCBBKFFHHDL);
		}
		if (JCBGHAODNDD != 0)
		{
			num ^= JCBGHAODNDD.GetHashCode();
		}
		if (MEKPIHJKJBL)
		{
			num ^= MEKPIHJKJBL.GetHashCode();
		}
		if (KHAJDKDHPGD != 0L)
		{
			num ^= KHAJDKDHPGD.GetHashCode();
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
		if (pos_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Pos);
		}
		if (rot_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Rot);
		}
		if (GNGKNDCKKKC != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(GNGKNDCKKKC);
		}
		if (nALBEFMOKIB_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(NALBEFMOKIB);
		}
		if (DCBBKFFHHDL != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(DCBBKFFHHDL);
		}
		if (JCBGHAODNDD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(JCBGHAODNDD);
		}
		if (MEKPIHJKJBL)
		{
			output.WriteRawTag(56);
			output.WriteBool(MEKPIHJKJBL);
		}
		if (KHAJDKDHPGD != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(KHAJDKDHPGD);
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
		if (pos_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Pos);
		}
		if (rot_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Rot);
		}
		if (GNGKNDCKKKC != 0f)
		{
			num += 5;
		}
		if (nALBEFMOKIB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NALBEFMOKIB);
		}
		if (DCBBKFFHHDL != 0f)
		{
			num += 5;
		}
		if (JCBGHAODNDD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JCBGHAODNDD);
		}
		if (MEKPIHJKJBL)
		{
			num += 2;
		}
		if (KHAJDKDHPGD != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(KHAJDKDHPGD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MACJBIAFNOI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pos_ != null)
		{
			if (pos_ == null)
			{
				Pos = new Vector();
			}
			Pos.MergeFrom(other.Pos);
		}
		if (other.rot_ != null)
		{
			if (rot_ == null)
			{
				Rot = new Vector();
			}
			Rot.MergeFrom(other.Rot);
		}
		if (other.GNGKNDCKKKC != 0f)
		{
			GNGKNDCKKKC = other.GNGKNDCKKKC;
		}
		if (other.nALBEFMOKIB_ != null)
		{
			if (nALBEFMOKIB_ == null)
			{
				NALBEFMOKIB = new Vector();
			}
			NALBEFMOKIB.MergeFrom(other.NALBEFMOKIB);
		}
		if (other.DCBBKFFHHDL != 0f)
		{
			DCBBKFFHHDL = other.DCBBKFFHHDL;
		}
		if (other.JCBGHAODNDD != 0)
		{
			JCBGHAODNDD = other.JCBGHAODNDD;
		}
		if (other.MEKPIHJKJBL)
		{
			MEKPIHJKJBL = other.MEKPIHJKJBL;
		}
		if (other.KHAJDKDHPGD != 0L)
		{
			KHAJDKDHPGD = other.KHAJDKDHPGD;
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
			case 10u:
				if (pos_ == null)
				{
					Pos = new Vector();
				}
				input.ReadMessage(Pos);
				break;
			case 18u:
				if (rot_ == null)
				{
					Rot = new Vector();
				}
				input.ReadMessage(Rot);
				break;
			case 29u:
				GNGKNDCKKKC = input.ReadFloat();
				break;
			case 34u:
				if (nALBEFMOKIB_ == null)
				{
					NALBEFMOKIB = new Vector();
				}
				input.ReadMessage(NALBEFMOKIB);
				break;
			case 45u:
				DCBBKFFHHDL = input.ReadFloat();
				break;
			case 48u:
				JCBGHAODNDD = input.ReadUInt32();
				break;
			case 56u:
				MEKPIHJKJBL = input.ReadBool();
				break;
			case 64u:
				KHAJDKDHPGD = input.ReadInt64();
				break;
			}
		}
	}
}
