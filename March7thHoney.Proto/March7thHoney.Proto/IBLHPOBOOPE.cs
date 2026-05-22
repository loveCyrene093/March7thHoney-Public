using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IBLHPOBOOPE : IMessage<IBLHPOBOOPE>, IMessage, IEquatable<IBLHPOBOOPE>, IDeepCloneable<IBLHPOBOOPE>, IBufferMessage
{
	private static readonly MessageParser<IBLHPOBOOPE> _parser = new MessageParser<IBLHPOBOOPE>(() => new IBLHPOBOOPE());

	private UnknownFieldSet _unknownFields;

	public const int IsWinFieldNumber = 8;

	private bool isWin_;

	public const int BattleEventIdFieldNumber = 9;

	private uint battleEventId_;

	public const int OHOGDBPKLFMFieldNumber = 15;

	private static readonly MapField<uint, uint>.Codec _map_oHOGDBPKLFM_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 122u);

	private readonly MapField<uint, uint> oHOGDBPKLFM_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IBLHPOBOOPE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IBLHPOBOOPEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleEventId
	{
		get
		{
			return battleEventId_;
		}
		set
		{
			battleEventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> OHOGDBPKLFM => oHOGDBPKLFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBLHPOBOOPE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBLHPOBOOPE(IBLHPOBOOPE other)
		: this()
	{
		isWin_ = other.isWin_;
		battleEventId_ = other.battleEventId_;
		oHOGDBPKLFM_ = other.oHOGDBPKLFM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IBLHPOBOOPE Clone()
	{
		return new IBLHPOBOOPE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IBLHPOBOOPE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IBLHPOBOOPE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (BattleEventId != other.BattleEventId)
		{
			return false;
		}
		if (!OHOGDBPKLFM.Equals(other.OHOGDBPKLFM))
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
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (BattleEventId != 0)
		{
			num ^= BattleEventId.GetHashCode();
		}
		num ^= OHOGDBPKLFM.GetHashCode();
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
		if (IsWin)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsWin);
		}
		if (BattleEventId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BattleEventId);
		}
		oHOGDBPKLFM_.WriteTo(ref output, _map_oHOGDBPKLFM_codec);
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
		if (IsWin)
		{
			num += 2;
		}
		if (BattleEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleEventId);
		}
		num += oHOGDBPKLFM_.CalculateSize(_map_oHOGDBPKLFM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IBLHPOBOOPE other)
	{
		if (other != null)
		{
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			if (other.BattleEventId != 0)
			{
				BattleEventId = other.BattleEventId;
			}
			oHOGDBPKLFM_.MergeFrom(other.oHOGDBPKLFM_);
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
			case 64u:
				IsWin = input.ReadBool();
				break;
			case 72u:
				BattleEventId = input.ReadUInt32();
				break;
			case 122u:
				oHOGDBPKLFM_.AddEntriesFrom(ref input, _map_oHOGDBPKLFM_codec);
				break;
			}
		}
	}
}
