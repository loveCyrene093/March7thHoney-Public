using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournSettleScRsp : IMessage<RogueTournSettleScRsp>, IMessage, IEquatable<RogueTournSettleScRsp>, IDeepCloneable<RogueTournSettleScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueTournSettleScRsp> _parser = new MessageParser<RogueTournSettleScRsp>(() => new RogueTournSettleScRsp());

	private UnknownFieldSet _unknownFields;

	public const int AFLJJJFCBINFieldNumber = 7;

	private BFEIPELFCDF aFLJJJFCBIN_;

	public const int EDKJMPACHNJFieldNumber = 9;

	private ALGJOMFCLKL eDKJMPACHNJ_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournSettleScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournSettleScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RogueTournSettleScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournSettleScRsp(RogueTournSettleScRsp other)
		: this()
	{
		aFLJJJFCBIN_ = ((other.aFLJJJFCBIN_ != null) ? other.aFLJJJFCBIN_.Clone() : null);
		eDKJMPACHNJ_ = ((other.eDKJMPACHNJ_ != null) ? other.eDKJMPACHNJ_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournSettleScRsp Clone()
	{
		return new RogueTournSettleScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournSettleScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournSettleScRsp other)
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
		if (Retcode != other.Retcode)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
			output.WriteRawTag(58);
			output.WriteMessage(AFLJJJFCBIN);
		}
		if (eDKJMPACHNJ_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(EDKJMPACHNJ);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournSettleScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aFLJJJFCBIN_ != null)
		{
			if (aFLJJJFCBIN_ == null)
			{
				AFLJJJFCBIN = new BFEIPELFCDF();
			}
			AFLJJJFCBIN.MergeFrom(other.AFLJJJFCBIN);
		}
		if (other.eDKJMPACHNJ_ != null)
		{
			if (eDKJMPACHNJ_ == null)
			{
				EDKJMPACHNJ = new ALGJOMFCLKL();
			}
			EDKJMPACHNJ.MergeFrom(other.EDKJMPACHNJ);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 58u:
				if (aFLJJJFCBIN_ == null)
				{
					AFLJJJFCBIN = new BFEIPELFCDF();
				}
				input.ReadMessage(AFLJJJFCBIN);
				break;
			case 74u:
				if (eDKJMPACHNJ_ == null)
				{
					EDKJMPACHNJ = new ALGJOMFCLKL();
				}
				input.ReadMessage(EDKJMPACHNJ);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
