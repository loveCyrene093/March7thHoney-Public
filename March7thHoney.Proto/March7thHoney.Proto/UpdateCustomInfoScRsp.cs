using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateCustomInfoScRsp : IMessage<UpdateCustomInfoScRsp>, IMessage, IEquatable<UpdateCustomInfoScRsp>, IDeepCloneable<UpdateCustomInfoScRsp>, IBufferMessage
{
	public enum NLPPPCHGGPFOneofCase
	{
		None = 0,
		Title = 5,
		FCOKOGNOGCA = 11
	}

	private static readonly MessageParser<UpdateCustomInfoScRsp> _parser = new MessageParser<UpdateCustomInfoScRsp>(() => new UpdateCustomInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int TitleFieldNumber = 5;

	public const int FCOKOGNOGCAFieldNumber = 11;

	private object nLPPPCHGGPF_;

	private NLPPPCHGGPFOneofCase nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateCustomInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateCustomInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public string Title
	{
		get
		{
			if (!HasTitle)
			{
				return "";
			}
			return (string)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = ProtoPreconditions.CheckNotNull(value, "value");
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.Title;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasTitle => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.Title;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCOKOGNOGCA
	{
		get
		{
			if (!HasFCOKOGNOGCA)
			{
				return 0u;
			}
			return (uint)nLPPPCHGGPF_;
		}
		set
		{
			nLPPPCHGGPF_ = value;
			nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.FCOKOGNOGCA;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFCOKOGNOGCA => nLPPPCHGGPFCase_ == NLPPPCHGGPFOneofCase.FCOKOGNOGCA;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLPPPCHGGPFOneofCase NLPPPCHGGPFCase => nLPPPCHGGPFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateCustomInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateCustomInfoScRsp(UpdateCustomInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		switch (other.NLPPPCHGGPFCase)
		{
		case NLPPPCHGGPFOneofCase.Title:
			Title = other.Title;
			break;
		case NLPPPCHGGPFOneofCase.FCOKOGNOGCA:
			FCOKOGNOGCA = other.FCOKOGNOGCA;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateCustomInfoScRsp Clone()
	{
		return new UpdateCustomInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearTitle()
	{
		if (HasTitle)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFCOKOGNOGCA()
	{
		if (HasFCOKOGNOGCA)
		{
			ClearNLPPPCHGGPF();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearNLPPPCHGGPF()
	{
		nLPPPCHGGPFCase_ = NLPPPCHGGPFOneofCase.None;
		nLPPPCHGGPF_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateCustomInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateCustomInfoScRsp other)
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
		if (Title != other.Title)
		{
			return false;
		}
		if (FCOKOGNOGCA != other.FCOKOGNOGCA)
		{
			return false;
		}
		if (NLPPPCHGGPFCase != other.NLPPPCHGGPFCase)
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
		if (HasTitle)
		{
			num ^= Title.GetHashCode();
		}
		if (HasFCOKOGNOGCA)
		{
			num ^= FCOKOGNOGCA.GetHashCode();
		}
		num ^= (int)nLPPPCHGGPFCase_;
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
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (HasTitle)
		{
			output.WriteRawTag(42);
			output.WriteString(Title);
		}
		if (HasFCOKOGNOGCA)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FCOKOGNOGCA);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (HasTitle)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (HasFCOKOGNOGCA)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCOKOGNOGCA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateCustomInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			switch (other.NLPPPCHGGPFCase)
			{
			case NLPPPCHGGPFOneofCase.Title:
				Title = other.Title;
				break;
			case NLPPPCHGGPFOneofCase.FCOKOGNOGCA:
				FCOKOGNOGCA = other.FCOKOGNOGCA;
				break;
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 42u:
				Title = input.ReadString();
				break;
			case 88u:
				FCOKOGNOGCA = input.ReadUInt32();
				break;
			}
		}
	}
}
