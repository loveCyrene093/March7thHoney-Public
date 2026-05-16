using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnableRogueTalentCsReq : IMessage<EnableRogueTalentCsReq>, IMessage, IEquatable<EnableRogueTalentCsReq>, IDeepCloneable<EnableRogueTalentCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnableRogueTalentCsReq> _parser = new MessageParser<EnableRogueTalentCsReq>(() => new EnableRogueTalentCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KFJEMIOJLPJFieldNumber = 8;

	private uint kFJEMIOJLPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnableRogueTalentCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnableRogueTalentCsReqReflection.Descriptor.MessageTypes[0];

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
	public EnableRogueTalentCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnableRogueTalentCsReq(EnableRogueTalentCsReq other)
		: this()
	{
		kFJEMIOJLPJ_ = other.kFJEMIOJLPJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnableRogueTalentCsReq Clone()
	{
		return new EnableRogueTalentCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnableRogueTalentCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnableRogueTalentCsReq other)
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
			output.WriteRawTag(64);
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
	public void MergeFrom(EnableRogueTalentCsReq other)
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
			if (num != 64)
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
