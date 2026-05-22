using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchThreeGetDataDataScRsp : IMessage<MatchThreeGetDataDataScRsp>, IMessage, IEquatable<MatchThreeGetDataDataScRsp>, IDeepCloneable<MatchThreeGetDataDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<MatchThreeGetDataDataScRsp> _parser = new MessageParser<MatchThreeGetDataDataScRsp>(() => new MatchThreeGetDataDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int DCFGOFNBLCMFieldNumber = 13;

	private MJMPDGNFIKN dCFGOFNBLCM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchThreeGetDataDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchThreeGetDataDataScRspReflection.Descriptor.MessageTypes[0];

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
	public MJMPDGNFIKN DCFGOFNBLCM
	{
		get
		{
			return dCFGOFNBLCM_;
		}
		set
		{
			dCFGOFNBLCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeGetDataDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeGetDataDataScRsp(MatchThreeGetDataDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		dCFGOFNBLCM_ = ((other.dCFGOFNBLCM_ != null) ? other.dCFGOFNBLCM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeGetDataDataScRsp Clone()
	{
		return new MatchThreeGetDataDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchThreeGetDataDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchThreeGetDataDataScRsp other)
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
		if (!object.Equals(DCFGOFNBLCM, other.DCFGOFNBLCM))
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
		if (dCFGOFNBLCM_ != null)
		{
			num ^= DCFGOFNBLCM.GetHashCode();
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
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (dCFGOFNBLCM_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(DCFGOFNBLCM);
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
		if (dCFGOFNBLCM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DCFGOFNBLCM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchThreeGetDataDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.dCFGOFNBLCM_ != null)
		{
			if (dCFGOFNBLCM_ == null)
			{
				DCFGOFNBLCM = new MJMPDGNFIKN();
			}
			DCFGOFNBLCM.MergeFrom(other.DCFGOFNBLCM);
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
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				if (dCFGOFNBLCM_ == null)
				{
					DCFGOFNBLCM = new MJMPDGNFIKN();
				}
				input.ReadMessage(DCFGOFNBLCM);
				break;
			}
		}
	}
}
