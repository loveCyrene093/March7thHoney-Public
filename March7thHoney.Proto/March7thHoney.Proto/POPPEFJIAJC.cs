using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class POPPEFJIAJC : IMessage<POPPEFJIAJC>, IMessage, IEquatable<POPPEFJIAJC>, IDeepCloneable<POPPEFJIAJC>, IBufferMessage
{
	private static readonly MessageParser<POPPEFJIAJC> _parser = new MessageParser<POPPEFJIAJC>(() => new POPPEFJIAJC());

	private UnknownFieldSet _unknownFields;

	public const int IsWinFieldNumber = 7;

	private bool isWin_;

	public const int EFDDNMGLANFFieldNumber = 8;

	private uint eFDDNMGLANF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<POPPEFJIAJC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => POPPEFJIAJCReflection.Descriptor.MessageTypes[0];

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
	public uint EFDDNMGLANF
	{
		get
		{
			return eFDDNMGLANF_;
		}
		set
		{
			eFDDNMGLANF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POPPEFJIAJC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POPPEFJIAJC(POPPEFJIAJC other)
		: this()
	{
		isWin_ = other.isWin_;
		eFDDNMGLANF_ = other.eFDDNMGLANF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public POPPEFJIAJC Clone()
	{
		return new POPPEFJIAJC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as POPPEFJIAJC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(POPPEFJIAJC other)
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
		if (EFDDNMGLANF != other.EFDDNMGLANF)
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
		if (EFDDNMGLANF != 0)
		{
			num ^= EFDDNMGLANF.GetHashCode();
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
		if (IsWin)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsWin);
		}
		if (EFDDNMGLANF != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EFDDNMGLANF);
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
		if (IsWin)
		{
			num += 2;
		}
		if (EFDDNMGLANF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EFDDNMGLANF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(POPPEFJIAJC other)
	{
		if (other != null)
		{
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			if (other.EFDDNMGLANF != 0)
			{
				EFDDNMGLANF = other.EFDDNMGLANF;
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
			case 56u:
				IsWin = input.ReadBool();
				break;
			case 64u:
				EFDDNMGLANF = input.ReadUInt32();
				break;
			}
		}
	}
}
