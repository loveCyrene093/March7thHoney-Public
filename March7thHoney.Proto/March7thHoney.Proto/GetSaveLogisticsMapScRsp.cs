using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetSaveLogisticsMapScRsp : IMessage<GetSaveLogisticsMapScRsp>, IMessage, IEquatable<GetSaveLogisticsMapScRsp>, IDeepCloneable<GetSaveLogisticsMapScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetSaveLogisticsMapScRsp> _parser = new MessageParser<GetSaveLogisticsMapScRsp>(() => new GetSaveLogisticsMapScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int JOBIHKPLHENFieldNumber = 12;

	private static readonly FieldCodec<CCBKGJGNDCL> _repeated_jOBIHKPLHEN_codec = FieldCodec.ForMessage(98u, CCBKGJGNDCL.Parser);

	private readonly RepeatedField<CCBKGJGNDCL> jOBIHKPLHEN_ = new RepeatedField<CCBKGJGNDCL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetSaveLogisticsMapScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetSaveLogisticsMapScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<CCBKGJGNDCL> JOBIHKPLHEN => jOBIHKPLHEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSaveLogisticsMapScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSaveLogisticsMapScRsp(GetSaveLogisticsMapScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		jOBIHKPLHEN_ = other.jOBIHKPLHEN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSaveLogisticsMapScRsp Clone()
	{
		return new GetSaveLogisticsMapScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetSaveLogisticsMapScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetSaveLogisticsMapScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!jOBIHKPLHEN_.Equals(other.jOBIHKPLHEN_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= jOBIHKPLHEN_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		jOBIHKPLHEN_.WriteTo(ref output, _repeated_jOBIHKPLHEN_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += jOBIHKPLHEN_.CalculateSize(_repeated_jOBIHKPLHEN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetSaveLogisticsMapScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			jOBIHKPLHEN_.Add(other.jOBIHKPLHEN_);
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
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				jOBIHKPLHEN_.AddEntriesFrom(ref input, _repeated_jOBIHKPLHEN_codec);
				break;
			}
		}
	}
}
