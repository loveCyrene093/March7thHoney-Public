using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PLECMCJNPIL : IMessage<PLECMCJNPIL>, IMessage, IEquatable<PLECMCJNPIL>, IDeepCloneable<PLECMCJNPIL>, IBufferMessage
{
	private static readonly MessageParser<PLECMCJNPIL> _parser = new MessageParser<PLECMCJNPIL>(() => new PLECMCJNPIL());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private string roomId_ = "";

	public const int JAFNCOMGABGFieldNumber = 2;

	private uint jAFNCOMGABG_;

	public const int SectionIdFieldNumber = 3;

	private uint sectionId_;

	public const int PlayerInfoFieldNumber = 4;

	private KKNHIMGNMPG playerInfo_;

	public const int FGDOBBBFKMNFieldNumber = 5;

	private static readonly FieldCodec<CONKDELHKGB> _repeated_fGDOBBBFKMN_codec = FieldCodec.ForMessage(42u, CONKDELHKGB.Parser);

	private readonly RepeatedField<CONKDELHKGB> fGDOBBBFKMN_ = new RepeatedField<CONKDELHKGB>();

	public const int HFOCHINPPBBFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_hFOCHINPPBB_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> hFOCHINPPBB_ = new RepeatedField<uint>();

	public const int DMNDJKPEIJNFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_dMNDJKPEIJN_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> dMNDJKPEIJN_ = new RepeatedField<uint>();

	public const int FCIJGKPKDKCFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_fCIJGKPKDKC_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> fCIJGKPKDKC_ = new RepeatedField<uint>();

	public const int MCNKBAKCAJBFieldNumber = 9;

	private static readonly FieldCodec<OGBJNEDMMEA> _repeated_mCNKBAKCAJB_codec = FieldCodec.ForMessage(74u, OGBJNEDMMEA.Parser);

	private readonly RepeatedField<OGBJNEDMMEA> mCNKBAKCAJB_ = new RepeatedField<OGBJNEDMMEA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PLECMCJNPIL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PLECMCJNPILReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAFNCOMGABG
	{
		get
		{
			return jAFNCOMGABG_;
		}
		set
		{
			jAFNCOMGABG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SectionId
	{
		get
		{
			return sectionId_;
		}
		set
		{
			sectionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKNHIMGNMPG PlayerInfo
	{
		get
		{
			return playerInfo_;
		}
		set
		{
			playerInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CONKDELHKGB> FGDOBBBFKMN => fGDOBBBFKMN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HFOCHINPPBB => hFOCHINPPBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DMNDJKPEIJN => dMNDJKPEIJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FCIJGKPKDKC => fCIJGKPKDKC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OGBJNEDMMEA> MCNKBAKCAJB => mCNKBAKCAJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLECMCJNPIL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLECMCJNPIL(PLECMCJNPIL other)
		: this()
	{
		roomId_ = other.roomId_;
		jAFNCOMGABG_ = other.jAFNCOMGABG_;
		sectionId_ = other.sectionId_;
		playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
		fGDOBBBFKMN_ = other.fGDOBBBFKMN_.Clone();
		hFOCHINPPBB_ = other.hFOCHINPPBB_.Clone();
		dMNDJKPEIJN_ = other.dMNDJKPEIJN_.Clone();
		fCIJGKPKDKC_ = other.fCIJGKPKDKC_.Clone();
		mCNKBAKCAJB_ = other.mCNKBAKCAJB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLECMCJNPIL Clone()
	{
		return new PLECMCJNPIL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PLECMCJNPIL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PLECMCJNPIL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (JAFNCOMGABG != other.JAFNCOMGABG)
		{
			return false;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (!object.Equals(PlayerInfo, other.PlayerInfo))
		{
			return false;
		}
		if (!fGDOBBBFKMN_.Equals(other.fGDOBBBFKMN_))
		{
			return false;
		}
		if (!hFOCHINPPBB_.Equals(other.hFOCHINPPBB_))
		{
			return false;
		}
		if (!dMNDJKPEIJN_.Equals(other.dMNDJKPEIJN_))
		{
			return false;
		}
		if (!fCIJGKPKDKC_.Equals(other.fCIJGKPKDKC_))
		{
			return false;
		}
		if (!mCNKBAKCAJB_.Equals(other.mCNKBAKCAJB_))
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
		if (RoomId.Length != 0)
		{
			num ^= RoomId.GetHashCode();
		}
		if (JAFNCOMGABG != 0)
		{
			num ^= JAFNCOMGABG.GetHashCode();
		}
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		if (playerInfo_ != null)
		{
			num ^= PlayerInfo.GetHashCode();
		}
		num ^= fGDOBBBFKMN_.GetHashCode();
		num ^= hFOCHINPPBB_.GetHashCode();
		num ^= dMNDJKPEIJN_.GetHashCode();
		num ^= fCIJGKPKDKC_.GetHashCode();
		num ^= mCNKBAKCAJB_.GetHashCode();
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
		if (RoomId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(RoomId);
		}
		if (JAFNCOMGABG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JAFNCOMGABG);
		}
		if (SectionId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(SectionId);
		}
		if (playerInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PlayerInfo);
		}
		fGDOBBBFKMN_.WriteTo(ref output, _repeated_fGDOBBBFKMN_codec);
		hFOCHINPPBB_.WriteTo(ref output, _repeated_hFOCHINPPBB_codec);
		dMNDJKPEIJN_.WriteTo(ref output, _repeated_dMNDJKPEIJN_codec);
		fCIJGKPKDKC_.WriteTo(ref output, _repeated_fCIJGKPKDKC_codec);
		mCNKBAKCAJB_.WriteTo(ref output, _repeated_mCNKBAKCAJB_codec);
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
		if (RoomId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RoomId);
		}
		if (JAFNCOMGABG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAFNCOMGABG);
		}
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		if (playerInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerInfo);
		}
		num += fGDOBBBFKMN_.CalculateSize(_repeated_fGDOBBBFKMN_codec);
		num += hFOCHINPPBB_.CalculateSize(_repeated_hFOCHINPPBB_codec);
		num += dMNDJKPEIJN_.CalculateSize(_repeated_dMNDJKPEIJN_codec);
		num += fCIJGKPKDKC_.CalculateSize(_repeated_fCIJGKPKDKC_codec);
		num += mCNKBAKCAJB_.CalculateSize(_repeated_mCNKBAKCAJB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PLECMCJNPIL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoomId.Length != 0)
		{
			RoomId = other.RoomId;
		}
		if (other.JAFNCOMGABG != 0)
		{
			JAFNCOMGABG = other.JAFNCOMGABG;
		}
		if (other.SectionId != 0)
		{
			SectionId = other.SectionId;
		}
		if (other.playerInfo_ != null)
		{
			if (playerInfo_ == null)
			{
				PlayerInfo = new KKNHIMGNMPG();
			}
			PlayerInfo.MergeFrom(other.PlayerInfo);
		}
		fGDOBBBFKMN_.Add(other.fGDOBBBFKMN_);
		hFOCHINPPBB_.Add(other.hFOCHINPPBB_);
		dMNDJKPEIJN_.Add(other.dMNDJKPEIJN_);
		fCIJGKPKDKC_.Add(other.fCIJGKPKDKC_);
		mCNKBAKCAJB_.Add(other.mCNKBAKCAJB_);
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
				RoomId = input.ReadString();
				break;
			case 16u:
				JAFNCOMGABG = input.ReadUInt32();
				break;
			case 24u:
				SectionId = input.ReadUInt32();
				break;
			case 34u:
				if (playerInfo_ == null)
				{
					PlayerInfo = new KKNHIMGNMPG();
				}
				input.ReadMessage(PlayerInfo);
				break;
			case 42u:
				fGDOBBBFKMN_.AddEntriesFrom(ref input, _repeated_fGDOBBBFKMN_codec);
				break;
			case 48u:
			case 50u:
				hFOCHINPPBB_.AddEntriesFrom(ref input, _repeated_hFOCHINPPBB_codec);
				break;
			case 56u:
			case 58u:
				dMNDJKPEIJN_.AddEntriesFrom(ref input, _repeated_dMNDJKPEIJN_codec);
				break;
			case 64u:
			case 66u:
				fCIJGKPKDKC_.AddEntriesFrom(ref input, _repeated_fCIJGKPKDKC_codec);
				break;
			case 74u:
				mCNKBAKCAJB_.AddEntriesFrom(ref input, _repeated_mCNKBAKCAJB_codec);
				break;
			}
		}
	}
}
