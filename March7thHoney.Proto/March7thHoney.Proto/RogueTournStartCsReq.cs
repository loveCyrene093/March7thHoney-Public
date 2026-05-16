using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournStartCsReq : IMessage<RogueTournStartCsReq>, IMessage, IEquatable<RogueTournStartCsReq>, IDeepCloneable<RogueTournStartCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueTournStartCsReq> _parser = new MessageParser<RogueTournStartCsReq>(() => new RogueTournStartCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KBJAHFLOOIJFieldNumber = 5;

	private bool kBJAHFLOOIJ_;

	public const int AreaIdFieldNumber = 6;

	private uint areaId_;

	public const int AvatarListFieldNumber = 7;

	private static readonly FieldCodec<HDDBJIKNEPF> _repeated_avatarList_codec = FieldCodec.ForMessage(58u, HDDBJIKNEPF.Parser);

	private readonly RepeatedField<HDDBJIKNEPF> avatarList_ = new RepeatedField<HDDBJIKNEPF>();

	public const int PNNKFBILIEHFieldNumber = 11;

	private bool pNNKFBILIEH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournStartCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournStartCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KBJAHFLOOIJ
	{
		get
		{
			return kBJAHFLOOIJ_;
		}
		set
		{
			kBJAHFLOOIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HDDBJIKNEPF> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PNNKFBILIEH
	{
		get
		{
			return pNNKFBILIEH_;
		}
		set
		{
			pNNKFBILIEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournStartCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournStartCsReq(RogueTournStartCsReq other)
		: this()
	{
		kBJAHFLOOIJ_ = other.kBJAHFLOOIJ_;
		areaId_ = other.areaId_;
		avatarList_ = other.avatarList_.Clone();
		pNNKFBILIEH_ = other.pNNKFBILIEH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournStartCsReq Clone()
	{
		return new RogueTournStartCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournStartCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournStartCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KBJAHFLOOIJ != other.KBJAHFLOOIJ)
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (PNNKFBILIEH != other.PNNKFBILIEH)
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
		if (KBJAHFLOOIJ)
		{
			num ^= KBJAHFLOOIJ.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
		if (PNNKFBILIEH)
		{
			num ^= PNNKFBILIEH.GetHashCode();
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
		if (KBJAHFLOOIJ)
		{
			output.WriteRawTag(40);
			output.WriteBool(KBJAHFLOOIJ);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AreaId);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (PNNKFBILIEH)
		{
			output.WriteRawTag(88);
			output.WriteBool(PNNKFBILIEH);
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
		if (KBJAHFLOOIJ)
		{
			num += 2;
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (PNNKFBILIEH)
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
	public void MergeFrom(RogueTournStartCsReq other)
	{
		if (other != null)
		{
			if (other.KBJAHFLOOIJ)
			{
				KBJAHFLOOIJ = other.KBJAHFLOOIJ;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			avatarList_.Add(other.avatarList_);
			if (other.PNNKFBILIEH)
			{
				PNNKFBILIEH = other.PNNKFBILIEH;
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
			case 40u:
				KBJAHFLOOIJ = input.ReadBool();
				break;
			case 48u:
				AreaId = input.ReadUInt32();
				break;
			case 58u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 88u:
				PNNKFBILIEH = input.ReadBool();
				break;
			}
		}
	}
}
