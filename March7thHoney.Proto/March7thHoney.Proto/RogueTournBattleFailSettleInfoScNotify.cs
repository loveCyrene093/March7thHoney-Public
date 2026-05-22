using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournBattleFailSettleInfoScNotify : IMessage<RogueTournBattleFailSettleInfoScNotify>, IMessage, IEquatable<RogueTournBattleFailSettleInfoScNotify>, IDeepCloneable<RogueTournBattleFailSettleInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueTournBattleFailSettleInfoScNotify> _parser = new MessageParser<RogueTournBattleFailSettleInfoScNotify>(() => new RogueTournBattleFailSettleInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int EDKJMPACHNJFieldNumber = 4;

	private ALGJOMFCLKL eDKJMPACHNJ_;

	public const int AFLJJJFCBINFieldNumber = 6;

	private BFEIPELFCDF aFLJJJFCBIN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournBattleFailSettleInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournBattleFailSettleInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ALGJOMFCLKL EDKJMPACHNJ
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
	public BFEIPELFCDF AFLJJJFCBIN
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
	public RogueTournBattleFailSettleInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournBattleFailSettleInfoScNotify(RogueTournBattleFailSettleInfoScNotify other)
		: this()
	{
		eDKJMPACHNJ_ = ((other.eDKJMPACHNJ_ != null) ? other.eDKJMPACHNJ_.Clone() : null);
		aFLJJJFCBIN_ = ((other.aFLJJJFCBIN_ != null) ? other.aFLJJJFCBIN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournBattleFailSettleInfoScNotify Clone()
	{
		return new RogueTournBattleFailSettleInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournBattleFailSettleInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournBattleFailSettleInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EDKJMPACHNJ, other.EDKJMPACHNJ))
		{
			return false;
		}
		if (!object.Equals(AFLJJJFCBIN, other.AFLJJJFCBIN))
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
		if (eDKJMPACHNJ_ != null)
		{
			num ^= EDKJMPACHNJ.GetHashCode();
		}
		if (aFLJJJFCBIN_ != null)
		{
			num ^= AFLJJJFCBIN.GetHashCode();
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
		if (eDKJMPACHNJ_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(EDKJMPACHNJ);
		}
		if (aFLJJJFCBIN_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AFLJJJFCBIN);
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
		if (eDKJMPACHNJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EDKJMPACHNJ);
		}
		if (aFLJJJFCBIN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AFLJJJFCBIN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournBattleFailSettleInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eDKJMPACHNJ_ != null)
		{
			if (eDKJMPACHNJ_ == null)
			{
				EDKJMPACHNJ = new ALGJOMFCLKL();
			}
			EDKJMPACHNJ.MergeFrom(other.EDKJMPACHNJ);
		}
		if (other.aFLJJJFCBIN_ != null)
		{
			if (aFLJJJFCBIN_ == null)
			{
				AFLJJJFCBIN = new BFEIPELFCDF();
			}
			AFLJJJFCBIN.MergeFrom(other.AFLJJJFCBIN);
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
				if (eDKJMPACHNJ_ == null)
				{
					EDKJMPACHNJ = new ALGJOMFCLKL();
				}
				input.ReadMessage(EDKJMPACHNJ);
				break;
			case 50u:
				if (aFLJJJFCBIN_ == null)
				{
					AFLJJJFCBIN = new BFEIPELFCDF();
				}
				input.ReadMessage(AFLJJJFCBIN);
				break;
			}
		}
	}
}
