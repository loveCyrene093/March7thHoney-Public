using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFantasticStoryActivityDataScRsp : IMessage<GetFantasticStoryActivityDataScRsp>, IMessage, IEquatable<GetFantasticStoryActivityDataScRsp>, IDeepCloneable<GetFantasticStoryActivityDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFantasticStoryActivityDataScRsp> _parser = new MessageParser<GetFantasticStoryActivityDataScRsp>(() => new GetFantasticStoryActivityDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ONAJJGCJOHAFieldNumber = 4;

	private FEDEIOIJJJC oNAJJGCJOHA_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFantasticStoryActivityDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFantasticStoryActivityDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FEDEIOIJJJC ONAJJGCJOHA
	{
		get
		{
			return oNAJJGCJOHA_;
		}
		set
		{
			oNAJJGCJOHA_ = value;
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
	public GetFantasticStoryActivityDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFantasticStoryActivityDataScRsp(GetFantasticStoryActivityDataScRsp other)
		: this()
	{
		oNAJJGCJOHA_ = ((other.oNAJJGCJOHA_ != null) ? other.oNAJJGCJOHA_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFantasticStoryActivityDataScRsp Clone()
	{
		return new GetFantasticStoryActivityDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFantasticStoryActivityDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFantasticStoryActivityDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ONAJJGCJOHA, other.ONAJJGCJOHA))
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
		if (oNAJJGCJOHA_ != null)
		{
			num ^= ONAJJGCJOHA.GetHashCode();
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
		if (oNAJJGCJOHA_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ONAJJGCJOHA);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
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
		if (oNAJJGCJOHA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ONAJJGCJOHA);
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
	public void MergeFrom(GetFantasticStoryActivityDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oNAJJGCJOHA_ != null)
		{
			if (oNAJJGCJOHA_ == null)
			{
				ONAJJGCJOHA = new FEDEIOIJJJC();
			}
			ONAJJGCJOHA.MergeFrom(other.ONAJJGCJOHA);
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
			case 34u:
				if (oNAJJGCJOHA_ == null)
				{
					ONAJJGCJOHA = new FEDEIOIJJJC();
				}
				input.ReadMessage(ONAJJGCJOHA);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
