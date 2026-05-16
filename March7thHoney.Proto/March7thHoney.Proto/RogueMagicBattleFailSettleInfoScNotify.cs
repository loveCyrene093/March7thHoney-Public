using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicBattleFailSettleInfoScNotify : IMessage<RogueMagicBattleFailSettleInfoScNotify>, IMessage, IEquatable<RogueMagicBattleFailSettleInfoScNotify>, IDeepCloneable<RogueMagicBattleFailSettleInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicBattleFailSettleInfoScNotify> _parser = new MessageParser<RogueMagicBattleFailSettleInfoScNotify>(() => new RogueMagicBattleFailSettleInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int AFLJJJFCBINFieldNumber = 1;

	private JKAIDKIGEGP aFLJJJFCBIN_;

	public const int EDKJMPACHNJFieldNumber = 11;

	private BHMJAJGOJPM eDKJMPACHNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicBattleFailSettleInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicBattleFailSettleInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKAIDKIGEGP AFLJJJFCBIN
	{
		get
		{
			return aFLJJJFCBIN_;
		}
		set
		{
			aFLJJJFCBIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BHMJAJGOJPM EDKJMPACHNJ
	{
		get
		{
			return eDKJMPACHNJ_;
		}
		set
		{
			eDKJMPACHNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicBattleFailSettleInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicBattleFailSettleInfoScNotify(RogueMagicBattleFailSettleInfoScNotify other)
		: this()
	{
		aFLJJJFCBIN_ = ((other.aFLJJJFCBIN_ != null) ? other.aFLJJJFCBIN_.Clone() : null);
		eDKJMPACHNJ_ = ((other.eDKJMPACHNJ_ != null) ? other.eDKJMPACHNJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicBattleFailSettleInfoScNotify Clone()
	{
		return new RogueMagicBattleFailSettleInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicBattleFailSettleInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicBattleFailSettleInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AFLJJJFCBIN, other.AFLJJJFCBIN))
		{
			return false;
		}
		if (!object.Equals(EDKJMPACHNJ, other.EDKJMPACHNJ))
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
		if (aFLJJJFCBIN_ != null)
		{
			num ^= AFLJJJFCBIN.GetHashCode();
		}
		if (eDKJMPACHNJ_ != null)
		{
			num ^= EDKJMPACHNJ.GetHashCode();
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
		if (aFLJJJFCBIN_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(AFLJJJFCBIN);
		}
		if (eDKJMPACHNJ_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(EDKJMPACHNJ);
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
		if (aFLJJJFCBIN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AFLJJJFCBIN);
		}
		if (eDKJMPACHNJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EDKJMPACHNJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicBattleFailSettleInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aFLJJJFCBIN_ != null)
		{
			if (aFLJJJFCBIN_ == null)
			{
				AFLJJJFCBIN = new JKAIDKIGEGP();
			}
			AFLJJJFCBIN.MergeFrom(other.AFLJJJFCBIN);
		}
		if (other.eDKJMPACHNJ_ != null)
		{
			if (eDKJMPACHNJ_ == null)
			{
				EDKJMPACHNJ = new BHMJAJGOJPM();
			}
			EDKJMPACHNJ.MergeFrom(other.EDKJMPACHNJ);
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
				if (aFLJJJFCBIN_ == null)
				{
					AFLJJJFCBIN = new JKAIDKIGEGP();
				}
				input.ReadMessage(AFLJJJFCBIN);
				break;
			case 90u:
				if (eDKJMPACHNJ_ == null)
				{
					EDKJMPACHNJ = new BHMJAJGOJPM();
				}
				input.ReadMessage(EDKJMPACHNJ);
				break;
			}
		}
	}
}
