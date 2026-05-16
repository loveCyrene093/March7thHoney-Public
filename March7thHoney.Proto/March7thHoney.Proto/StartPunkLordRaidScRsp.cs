using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartPunkLordRaidScRsp : IMessage<StartPunkLordRaidScRsp>, IMessage, IEquatable<StartPunkLordRaidScRsp>, IDeepCloneable<StartPunkLordRaidScRsp>, IBufferMessage
{
	private static readonly MessageParser<StartPunkLordRaidScRsp> _parser = new MessageParser<StartPunkLordRaidScRsp>(() => new StartPunkLordRaidScRsp());

	private UnknownFieldSet _unknownFields;

	public const int FFCDPHMJJKGFieldNumber = 4;

	private CIKJHLMOOIK fFCDPHMJJKG_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int KGJJCABAHOGFieldNumber = 8;

	private long kGJJCABAHOG_;

	public const int GDBIIMNJLBAFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_gDBIIMNJLBA_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> gDBIIMNJLBA_ = new RepeatedField<uint>();

	public const int GEALJOJCJFNFieldNumber = 12;

	private bool gEALJOJCJFN_;

	public const int SceneFieldNumber = 15;

	private FNJJCIGJIKC scene_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartPunkLordRaidScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartPunkLordRaidScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIKJHLMOOIK FFCDPHMJJKG
	{
		get
		{
			return fFCDPHMJJKG_;
		}
		set
		{
			fFCDPHMJJKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long KGJJCABAHOG
	{
		get
		{
			return kGJJCABAHOG_;
		}
		set
		{
			kGJJCABAHOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GDBIIMNJLBA => gDBIIMNJLBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GEALJOJCJFN
	{
		get
		{
			return gEALJOJCJFN_;
		}
		set
		{
			gEALJOJCJFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNJJCIGJIKC Scene
	{
		get
		{
			return scene_;
		}
		set
		{
			scene_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartPunkLordRaidScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartPunkLordRaidScRsp(StartPunkLordRaidScRsp other)
		: this()
	{
		fFCDPHMJJKG_ = ((other.fFCDPHMJJKG_ != null) ? other.fFCDPHMJJKG_.Clone() : null);
		retcode_ = other.retcode_;
		kGJJCABAHOG_ = other.kGJJCABAHOG_;
		gDBIIMNJLBA_ = other.gDBIIMNJLBA_.Clone();
		gEALJOJCJFN_ = other.gEALJOJCJFN_;
		scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartPunkLordRaidScRsp Clone()
	{
		return new StartPunkLordRaidScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartPunkLordRaidScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartPunkLordRaidScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FFCDPHMJJKG, other.FFCDPHMJJKG))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (KGJJCABAHOG != other.KGJJCABAHOG)
		{
			return false;
		}
		if (!gDBIIMNJLBA_.Equals(other.gDBIIMNJLBA_))
		{
			return false;
		}
		if (GEALJOJCJFN != other.GEALJOJCJFN)
		{
			return false;
		}
		if (!object.Equals(Scene, other.Scene))
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
		if (fFCDPHMJJKG_ != null)
		{
			num ^= FFCDPHMJJKG.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (KGJJCABAHOG != 0L)
		{
			num ^= KGJJCABAHOG.GetHashCode();
		}
		num ^= gDBIIMNJLBA_.GetHashCode();
		if (GEALJOJCJFN)
		{
			num ^= GEALJOJCJFN.GetHashCode();
		}
		if (scene_ != null)
		{
			num ^= Scene.GetHashCode();
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
		if (fFCDPHMJJKG_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(FFCDPHMJJKG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (KGJJCABAHOG != 0L)
		{
			output.WriteRawTag(64);
			output.WriteInt64(KGJJCABAHOG);
		}
		gDBIIMNJLBA_.WriteTo(ref output, _repeated_gDBIIMNJLBA_codec);
		if (GEALJOJCJFN)
		{
			output.WriteRawTag(96);
			output.WriteBool(GEALJOJCJFN);
		}
		if (scene_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(Scene);
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
		if (fFCDPHMJJKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FFCDPHMJJKG);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (KGJJCABAHOG != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(KGJJCABAHOG);
		}
		num += gDBIIMNJLBA_.CalculateSize(_repeated_gDBIIMNJLBA_codec);
		if (GEALJOJCJFN)
		{
			num += 2;
		}
		if (scene_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Scene);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartPunkLordRaidScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fFCDPHMJJKG_ != null)
		{
			if (fFCDPHMJJKG_ == null)
			{
				FFCDPHMJJKG = new CIKJHLMOOIK();
			}
			FFCDPHMJJKG.MergeFrom(other.FFCDPHMJJKG);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.KGJJCABAHOG != 0L)
		{
			KGJJCABAHOG = other.KGJJCABAHOG;
		}
		gDBIIMNJLBA_.Add(other.gDBIIMNJLBA_);
		if (other.GEALJOJCJFN)
		{
			GEALJOJCJFN = other.GEALJOJCJFN;
		}
		if (other.scene_ != null)
		{
			if (scene_ == null)
			{
				Scene = new FNJJCIGJIKC();
			}
			Scene.MergeFrom(other.Scene);
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
			case 34u:
				if (fFCDPHMJJKG_ == null)
				{
					FFCDPHMJJKG = new CIKJHLMOOIK();
				}
				input.ReadMessage(FFCDPHMJJKG);
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
				KGJJCABAHOG = input.ReadInt64();
				break;
			case 72u:
			case 74u:
				gDBIIMNJLBA_.AddEntriesFrom(ref input, _repeated_gDBIIMNJLBA_codec);
				break;
			case 96u:
				GEALJOJCJFN = input.ReadBool();
				break;
			case 122u:
				if (scene_ == null)
				{
					Scene = new FNJJCIGJIKC();
				}
				input.ReadMessage(Scene);
				break;
			}
		}
	}
}
