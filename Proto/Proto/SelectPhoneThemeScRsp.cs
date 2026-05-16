using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SelectPhoneThemeScRsp : IMessage<SelectPhoneThemeScRsp>, IMessage, IEquatable<SelectPhoneThemeScRsp>, IDeepCloneable<SelectPhoneThemeScRsp>, IBufferMessage
{
	private static readonly MessageParser<SelectPhoneThemeScRsp> _parser = new MessageParser<SelectPhoneThemeScRsp>(() => new SelectPhoneThemeScRsp());

	private UnknownFieldSet _unknownFields;

	public const int NALLEBNBPKBFieldNumber = 1;

	private uint nALLEBNBPKB_;

	public const int CurPhoneThemeFieldNumber = 6;

	private uint curPhoneTheme_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SelectPhoneThemeScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SelectPhoneThemeScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NALLEBNBPKB
	{
		get
		{
			return nALLEBNBPKB_;
		}
		set
		{
			nALLEBNBPKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurPhoneTheme
	{
		get
		{
			return curPhoneTheme_;
		}
		set
		{
			curPhoneTheme_ = value;
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
	public SelectPhoneThemeScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPhoneThemeScRsp(SelectPhoneThemeScRsp other)
		: this()
	{
		nALLEBNBPKB_ = other.nALLEBNBPKB_;
		curPhoneTheme_ = other.curPhoneTheme_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPhoneThemeScRsp Clone()
	{
		return new SelectPhoneThemeScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SelectPhoneThemeScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelectPhoneThemeScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NALLEBNBPKB != other.NALLEBNBPKB)
		{
			return false;
		}
		if (CurPhoneTheme != other.CurPhoneTheme)
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
		if (NALLEBNBPKB != 0)
		{
			num ^= NALLEBNBPKB.GetHashCode();
		}
		if (CurPhoneTheme != 0)
		{
			num ^= CurPhoneTheme.GetHashCode();
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
		if (NALLEBNBPKB != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NALLEBNBPKB);
		}
		if (CurPhoneTheme != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CurPhoneTheme);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
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
		if (NALLEBNBPKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NALLEBNBPKB);
		}
		if (CurPhoneTheme != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurPhoneTheme);
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
	public void MergeFrom(SelectPhoneThemeScRsp other)
	{
		if (other != null)
		{
			if (other.NALLEBNBPKB != 0)
			{
				NALLEBNBPKB = other.NALLEBNBPKB;
			}
			if (other.CurPhoneTheme != 0)
			{
				CurPhoneTheme = other.CurPhoneTheme;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 8u:
				NALLEBNBPKB = input.ReadUInt32();
				break;
			case 48u:
				CurPhoneTheme = input.ReadUInt32();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
