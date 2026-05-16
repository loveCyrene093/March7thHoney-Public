using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LMCBEJOFCGI : IMessage<LMCBEJOFCGI>, IMessage, IEquatable<LMCBEJOFCGI>, IDeepCloneable<LMCBEJOFCGI>, IBufferMessage
{
	private static readonly MessageParser<LMCBEJOFCGI> _parser = new MessageParser<LMCBEJOFCGI>(() => new LMCBEJOFCGI());

	private UnknownFieldSet _unknownFields;

	public const int DMHLLKBMHELFieldNumber = 12;

	private ulong dMHLLKBMHEL_;

	public const int FPHGHAPGNAEFieldNumber = 14;

	private MLIBLHFBAFJ fPHGHAPGNAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LMCBEJOFCGI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LMCBEJOFCGIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong DMHLLKBMHEL
	{
		get
		{
			return dMHLLKBMHEL_;
		}
		set
		{
			dMHLLKBMHEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLIBLHFBAFJ FPHGHAPGNAE
	{
		get
		{
			return fPHGHAPGNAE_;
		}
		set
		{
			fPHGHAPGNAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMCBEJOFCGI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMCBEJOFCGI(LMCBEJOFCGI other)
		: this()
	{
		dMHLLKBMHEL_ = other.dMHLLKBMHEL_;
		fPHGHAPGNAE_ = other.fPHGHAPGNAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMCBEJOFCGI Clone()
	{
		return new LMCBEJOFCGI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LMCBEJOFCGI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LMCBEJOFCGI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DMHLLKBMHEL != other.DMHLLKBMHEL)
		{
			return false;
		}
		if (FPHGHAPGNAE != other.FPHGHAPGNAE)
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
		if (DMHLLKBMHEL != 0L)
		{
			num ^= DMHLLKBMHEL.GetHashCode();
		}
		if (FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
		{
			num ^= FPHGHAPGNAE.GetHashCode();
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
		if (DMHLLKBMHEL != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(DMHLLKBMHEL);
		}
		if (FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)FPHGHAPGNAE);
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
		if (DMHLLKBMHEL != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(DMHLLKBMHEL);
		}
		if (FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FPHGHAPGNAE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LMCBEJOFCGI other)
	{
		if (other != null)
		{
			if (other.DMHLLKBMHEL != 0L)
			{
				DMHLLKBMHEL = other.DMHLLKBMHEL;
			}
			if (other.FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
			{
				FPHGHAPGNAE = other.FPHGHAPGNAE;
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
			case 96u:
				DMHLLKBMHEL = input.ReadUInt64();
				break;
			case 112u:
				FPHGHAPGNAE = (MLIBLHFBAFJ)input.ReadEnum();
				break;
			}
		}
	}
}
