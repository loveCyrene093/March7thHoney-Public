using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSystemInfo : IMessage<GridFightSystemInfo>, IMessage, IEquatable<GridFightSystemInfo>, IDeepCloneable<GridFightSystemInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightSystemInfo> _parser = new MessageParser<GridFightSystemInfo>(() => new GridFightSystemInfo());

	private UnknownFieldSet _unknownFields;

	public const int EGLCKGKECAJFieldNumber = 8;

	private GridFightStaticGameInfo eGLCKGKECAJ_;

	public const int FCKKGFFLDFAFieldNumber = 13;

	private MIGEAHDEBOE fCKKGFFLDFA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSystemInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSystemInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightStaticGameInfo EGLCKGKECAJ
	{
		get
		{
			return eGLCKGKECAJ_;
		}
		set
		{
			eGLCKGKECAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIGEAHDEBOE FCKKGFFLDFA
	{
		get
		{
			return fCKKGFFLDFA_;
		}
		set
		{
			fCKKGFFLDFA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSystemInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSystemInfo(GridFightSystemInfo other)
		: this()
	{
		eGLCKGKECAJ_ = ((other.eGLCKGKECAJ_ != null) ? other.eGLCKGKECAJ_.Clone() : null);
		fCKKGFFLDFA_ = ((other.fCKKGFFLDFA_ != null) ? other.fCKKGFFLDFA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSystemInfo Clone()
	{
		return new GridFightSystemInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSystemInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSystemInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EGLCKGKECAJ, other.EGLCKGKECAJ))
		{
			return false;
		}
		if (!object.Equals(FCKKGFFLDFA, other.FCKKGFFLDFA))
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
		if (eGLCKGKECAJ_ != null)
		{
			num ^= EGLCKGKECAJ.GetHashCode();
		}
		if (fCKKGFFLDFA_ != null)
		{
			num ^= FCKKGFFLDFA.GetHashCode();
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
		if (eGLCKGKECAJ_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(EGLCKGKECAJ);
		}
		if (fCKKGFFLDFA_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(FCKKGFFLDFA);
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
		if (eGLCKGKECAJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EGLCKGKECAJ);
		}
		if (fCKKGFFLDFA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCKKGFFLDFA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSystemInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eGLCKGKECAJ_ != null)
		{
			if (eGLCKGKECAJ_ == null)
			{
				EGLCKGKECAJ = new GridFightStaticGameInfo();
			}
			EGLCKGKECAJ.MergeFrom(other.EGLCKGKECAJ);
		}
		if (other.fCKKGFFLDFA_ != null)
		{
			if (fCKKGFFLDFA_ == null)
			{
				FCKKGFFLDFA = new MIGEAHDEBOE();
			}
			FCKKGFFLDFA.MergeFrom(other.FCKKGFFLDFA);
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
			case 66u:
				if (eGLCKGKECAJ_ == null)
				{
					EGLCKGKECAJ = new GridFightStaticGameInfo();
				}
				input.ReadMessage(EGLCKGKECAJ);
				break;
			case 106u:
				if (fCKKGFFLDFA_ == null)
				{
					FCKKGFFLDFA = new MIGEAHDEBOE();
				}
				input.ReadMessage(FCKKGFFLDFA);
				break;
			}
		}
	}
}
