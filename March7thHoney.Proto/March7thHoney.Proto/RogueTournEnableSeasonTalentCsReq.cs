using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournEnableSeasonTalentCsReq : IMessage<RogueTournEnableSeasonTalentCsReq>, IMessage, IEquatable<RogueTournEnableSeasonTalentCsReq>, IDeepCloneable<RogueTournEnableSeasonTalentCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueTournEnableSeasonTalentCsReq> _parser = new MessageParser<RogueTournEnableSeasonTalentCsReq>(() => new RogueTournEnableSeasonTalentCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KFJEMIOJLPJFieldNumber = 4;

	private uint kFJEMIOJLPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournEnableSeasonTalentCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournEnableSeasonTalentCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KFJEMIOJLPJ
	{
		get
		{
			return kFJEMIOJLPJ_;
		}
		set
		{
			kFJEMIOJLPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnableSeasonTalentCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnableSeasonTalentCsReq(RogueTournEnableSeasonTalentCsReq other)
		: this()
	{
		kFJEMIOJLPJ_ = other.kFJEMIOJLPJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournEnableSeasonTalentCsReq Clone()
	{
		return new RogueTournEnableSeasonTalentCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournEnableSeasonTalentCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournEnableSeasonTalentCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KFJEMIOJLPJ != other.KFJEMIOJLPJ)
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
		if (KFJEMIOJLPJ != 0)
		{
			num ^= KFJEMIOJLPJ.GetHashCode();
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
		if (KFJEMIOJLPJ != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(KFJEMIOJLPJ);
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
		if (KFJEMIOJLPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KFJEMIOJLPJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournEnableSeasonTalentCsReq other)
	{
		if (other != null)
		{
			if (other.KFJEMIOJLPJ != 0)
			{
				KFJEMIOJLPJ = other.KFJEMIOJLPJ;
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
			if (num != 32)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KFJEMIOJLPJ = input.ReadUInt32();
			}
		}
	}
}
