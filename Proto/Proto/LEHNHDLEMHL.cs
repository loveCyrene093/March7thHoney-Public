using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LEHNHDLEMHL : IMessage<LEHNHDLEMHL>, IMessage, IEquatable<LEHNHDLEMHL>, IDeepCloneable<LEHNHDLEMHL>, IBufferMessage
{
	private static readonly MessageParser<LEHNHDLEMHL> _parser = new MessageParser<LEHNHDLEMHL>(() => new LEHNHDLEMHL());

	private UnknownFieldSet _unknownFields;

	public const int NAJCPOPJGLBFieldNumber = 2;

	private int nAJCPOPJGLB_;

	public const int IdFieldNumber = 3;

	private uint id_;

	public const int HpFieldNumber = 5;

	private int hp_;

	public const int MPLINCADODKFieldNumber = 6;

	private BCMMLADBEAM mPLINCADODK_;

	public const int KAEBCNNAKIDFieldNumber = 13;

	private bool kAEBCNNAKID_;

	public const int BMGABAHLGJIFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_bMGABAHLGJI_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> bMGABAHLGJI_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LEHNHDLEMHL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LEHNHDLEMHLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NAJCPOPJGLB
	{
		get
		{
			return nAJCPOPJGLB_;
		}
		set
		{
			nAJCPOPJGLB_ = value;
		}
	}

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
	public int Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCMMLADBEAM MPLINCADODK
	{
		get
		{
			return mPLINCADODK_;
		}
		set
		{
			mPLINCADODK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KAEBCNNAKID
	{
		get
		{
			return kAEBCNNAKID_;
		}
		set
		{
			kAEBCNNAKID_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BMGABAHLGJI => bMGABAHLGJI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEHNHDLEMHL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEHNHDLEMHL(LEHNHDLEMHL other)
		: this()
	{
		nAJCPOPJGLB_ = other.nAJCPOPJGLB_;
		id_ = other.id_;
		hp_ = other.hp_;
		mPLINCADODK_ = ((other.mPLINCADODK_ != null) ? other.mPLINCADODK_.Clone() : null);
		kAEBCNNAKID_ = other.kAEBCNNAKID_;
		bMGABAHLGJI_ = other.bMGABAHLGJI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LEHNHDLEMHL Clone()
	{
		return new LEHNHDLEMHL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LEHNHDLEMHL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LEHNHDLEMHL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NAJCPOPJGLB != other.NAJCPOPJGLB)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (!object.Equals(MPLINCADODK, other.MPLINCADODK))
		{
			return false;
		}
		if (KAEBCNNAKID != other.KAEBCNNAKID)
		{
			return false;
		}
		if (!bMGABAHLGJI_.Equals(other.bMGABAHLGJI_))
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
		if (NAJCPOPJGLB != 0)
		{
			num ^= NAJCPOPJGLB.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (mPLINCADODK_ != null)
		{
			num ^= MPLINCADODK.GetHashCode();
		}
		if (KAEBCNNAKID)
		{
			num ^= KAEBCNNAKID.GetHashCode();
		}
		num ^= bMGABAHLGJI_.GetHashCode();
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
		if (NAJCPOPJGLB != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(NAJCPOPJGLB);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Id);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Hp);
		}
		if (mPLINCADODK_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(MPLINCADODK);
		}
		if (KAEBCNNAKID)
		{
			output.WriteRawTag(104);
			output.WriteBool(KAEBCNNAKID);
		}
		bMGABAHLGJI_.WriteTo(ref output, _repeated_bMGABAHLGJI_codec);
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
		if (NAJCPOPJGLB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NAJCPOPJGLB);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Hp);
		}
		if (mPLINCADODK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MPLINCADODK);
		}
		if (KAEBCNNAKID)
		{
			num += 2;
		}
		num += bMGABAHLGJI_.CalculateSize(_repeated_bMGABAHLGJI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LEHNHDLEMHL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.NAJCPOPJGLB != 0)
		{
			NAJCPOPJGLB = other.NAJCPOPJGLB;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.Hp != 0)
		{
			Hp = other.Hp;
		}
		if (other.mPLINCADODK_ != null)
		{
			if (mPLINCADODK_ == null)
			{
				MPLINCADODK = new BCMMLADBEAM();
			}
			MPLINCADODK.MergeFrom(other.MPLINCADODK);
		}
		if (other.KAEBCNNAKID)
		{
			KAEBCNNAKID = other.KAEBCNNAKID;
		}
		bMGABAHLGJI_.Add(other.bMGABAHLGJI_);
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
			case 16u:
				NAJCPOPJGLB = input.ReadInt32();
				break;
			case 24u:
				Id = input.ReadUInt32();
				break;
			case 40u:
				Hp = input.ReadInt32();
				break;
			case 50u:
				if (mPLINCADODK_ == null)
				{
					MPLINCADODK = new BCMMLADBEAM();
				}
				input.ReadMessage(MPLINCADODK);
				break;
			case 104u:
				KAEBCNNAKID = input.ReadBool();
				break;
			case 112u:
			case 114u:
				bMGABAHLGJI_.AddEntriesFrom(ref input, _repeated_bMGABAHLGJI_codec);
				break;
			}
		}
	}
}
