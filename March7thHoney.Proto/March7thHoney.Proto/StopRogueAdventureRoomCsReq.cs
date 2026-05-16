using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StopRogueAdventureRoomCsReq : IMessage<StopRogueAdventureRoomCsReq>, IMessage, IEquatable<StopRogueAdventureRoomCsReq>, IDeepCloneable<StopRogueAdventureRoomCsReq>, IBufferMessage
{
	private static readonly MessageParser<StopRogueAdventureRoomCsReq> _parser = new MessageParser<StopRogueAdventureRoomCsReq>(() => new StopRogueAdventureRoomCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KGEPGNKIIIEFieldNumber = 1;

	private uint kGEPGNKIIIE_;

	public const int OACLIHKCNKGFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_oACLIHKCNKG_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> oACLIHKCNKG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StopRogueAdventureRoomCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StopRogueAdventureRoomCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KGEPGNKIIIE
	{
		get
		{
			return kGEPGNKIIIE_;
		}
		set
		{
			kGEPGNKIIIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OACLIHKCNKG => oACLIHKCNKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StopRogueAdventureRoomCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StopRogueAdventureRoomCsReq(StopRogueAdventureRoomCsReq other)
		: this()
	{
		kGEPGNKIIIE_ = other.kGEPGNKIIIE_;
		oACLIHKCNKG_ = other.oACLIHKCNKG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StopRogueAdventureRoomCsReq Clone()
	{
		return new StopRogueAdventureRoomCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StopRogueAdventureRoomCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StopRogueAdventureRoomCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KGEPGNKIIIE != other.KGEPGNKIIIE)
		{
			return false;
		}
		if (!oACLIHKCNKG_.Equals(other.oACLIHKCNKG_))
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
		if (KGEPGNKIIIE != 0)
		{
			num ^= KGEPGNKIIIE.GetHashCode();
		}
		num ^= oACLIHKCNKG_.GetHashCode();
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
		if (KGEPGNKIIIE != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KGEPGNKIIIE);
		}
		oACLIHKCNKG_.WriteTo(ref output, _repeated_oACLIHKCNKG_codec);
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
		if (KGEPGNKIIIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KGEPGNKIIIE);
		}
		num += oACLIHKCNKG_.CalculateSize(_repeated_oACLIHKCNKG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StopRogueAdventureRoomCsReq other)
	{
		if (other != null)
		{
			if (other.KGEPGNKIIIE != 0)
			{
				KGEPGNKIIIE = other.KGEPGNKIIIE;
			}
			oACLIHKCNKG_.Add(other.oACLIHKCNKG_);
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
				KGEPGNKIIIE = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				oACLIHKCNKG_.AddEntriesFrom(ref input, _repeated_oACLIHKCNKG_codec);
				break;
			}
		}
	}
}
