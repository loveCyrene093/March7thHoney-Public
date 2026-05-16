using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueModifierSelectCellScRsp : IMessage<RogueModifierSelectCellScRsp>, IMessage, IEquatable<RogueModifierSelectCellScRsp>, IDeepCloneable<RogueModifierSelectCellScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueModifierSelectCellScRsp> _parser = new MessageParser<RogueModifierSelectCellScRsp>(() => new RogueModifierSelectCellScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int EIIAGABAFECFieldNumber = 9;

	private uint eIIAGABAFEC_;

	public const int FNLDFGLGEOAFieldNumber = 11;

	private ItemList fNLDFGLGEOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueModifierSelectCellScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueModifierSelectCellScRspReflection.Descriptor.MessageTypes[0];

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
	public uint EIIAGABAFEC
	{
		get
		{
			return eIIAGABAFEC_;
		}
		set
		{
			eIIAGABAFEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList FNLDFGLGEOA
	{
		get
		{
			return fNLDFGLGEOA_;
		}
		set
		{
			fNLDFGLGEOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueModifierSelectCellScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueModifierSelectCellScRsp(RogueModifierSelectCellScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		eIIAGABAFEC_ = other.eIIAGABAFEC_;
		fNLDFGLGEOA_ = ((other.fNLDFGLGEOA_ != null) ? other.fNLDFGLGEOA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueModifierSelectCellScRsp Clone()
	{
		return new RogueModifierSelectCellScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueModifierSelectCellScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueModifierSelectCellScRsp other)
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
		if (EIIAGABAFEC != other.EIIAGABAFEC)
		{
			return false;
		}
		if (!object.Equals(FNLDFGLGEOA, other.FNLDFGLGEOA))
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
		if (EIIAGABAFEC != 0)
		{
			num ^= EIIAGABAFEC.GetHashCode();
		}
		if (fNLDFGLGEOA_ != null)
		{
			num ^= FNLDFGLGEOA.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (EIIAGABAFEC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EIIAGABAFEC);
		}
		if (fNLDFGLGEOA_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(FNLDFGLGEOA);
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
		if (EIIAGABAFEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIIAGABAFEC);
		}
		if (fNLDFGLGEOA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FNLDFGLGEOA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueModifierSelectCellScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.EIIAGABAFEC != 0)
		{
			EIIAGABAFEC = other.EIIAGABAFEC;
		}
		if (other.fNLDFGLGEOA_ != null)
		{
			if (fNLDFGLGEOA_ == null)
			{
				FNLDFGLGEOA = new ItemList();
			}
			FNLDFGLGEOA.MergeFrom(other.FNLDFGLGEOA);
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				EIIAGABAFEC = input.ReadUInt32();
				break;
			case 90u:
				if (fNLDFGLGEOA_ == null)
				{
					FNLDFGLGEOA = new ItemList();
				}
				input.ReadMessage(FNLDFGLGEOA);
				break;
			}
		}
	}
}
